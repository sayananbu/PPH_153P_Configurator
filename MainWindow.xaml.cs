﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace PPH_153P_Configurator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitPresets();
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
        }
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }

        }
        private void InitPresets()
        {
            pathToPresets = GetPathToPresets(Global.defaultSettingsPath);
            DisplayChannelList(ChannelLst, pathToPresets);
        }
        public string pathToPresets { get; set; }
        private string GetPathToPresets(string settingPath)
        {
            string presetPath;
            try
            {
                presetPath = XML.DeserializeSettingsXML(settingPath);
            }catch
            {
                presetPath= "Presets.xml";
                File.WriteAllText(settingPath, string.Empty);
                XML.SerializeXML(presetPath, settingPath);
            }
            return presetPath;
        }
        //Проверка ввода числа типа float
        private void CheckFloatNumberInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")
               && (!textBox.Text.Contains(".")
               && textBox.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        //Проверка ввода целого числа
        private void CheckIntNumberInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        //Перенаправление фокуса с некоторых элементов
        private void RedirectFocus(object sender, MouseButtonEventArgs e)
        {
            MainGrid.Focus();
        }

        //Закрытие потока
        private void MainWindow1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (this.DataContext as Controller).StopThread();
        }
        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            var controller = (Controller)this.DataContext;
            string alert = App.Language.Name == "ru-RU" ? "Утройство CAN не найдено" : "CAN device was not found";
            if (!controller.IsCANDeviceFound())
                MessageBox.Show(alert);
            Copier.CopyValues(controller.InputData, controller.MainData);
        }
        
        //Перезапускает приложение
        private void ButtonClickReconnect(object sender, RoutedEventArgs e)
        {
            Close();
            Process.Start(Assembly.GetExecutingAssembly().Location);
        }
        //Копирует в input текущие данные
        private void ButtonClickRefreshInputData(object sender, RoutedEventArgs e)
        {
            var controller = (Controller)this.DataContext;
            Copier.CopyValues(controller.InputData, controller.MainData);
        }

        //Отправка данных для записи
        private void ButtonClickSendData(object sender, RoutedEventArgs e)
        {
            var controller = (Controller)this.DataContext;
            controller.SendData(controller.CompareDataToSend(controller.InputData, controller.MainData));
            string prompt = App.Language.Name == "ru-RU" ? "Данные отправлены" : "Data uploading";
                PromptWindow alert = new PromptWindow(prompt, 1000);
            alert.ShowDialog();
        }

        //Открывает файл конфигурации и в дальнейшем записывает в него
        private void OpenFromFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                pathToPresets = dialog.SafeFileName;
                if(DisplayChannelList(ChannelLst, pathToPresets))
                {
                    XML.SerializeXML(pathToPresets, Global.defaultSettingsPath);
                    PresetLst.Items.Clear();
                }
                else
                {
                    ChannelLst.Items.Clear();
                    PresetLst.Items.Clear();
                }
                
            }
        }

        //Вспомогательные функции
        //Добавляют канал/конфиг в listvie
        private void AddPresetToListView(Preset preset, ListView target)
        {
            ListViewItem item = new ListViewItem();
            item.Content = $"{preset.Name}";
            item.Tag = preset;
            target.Items.Add(item);
        }
        private void AddChannelToListView(Channel channel, ListView target)
        {
            ListViewItem item = new ListViewItem();
            item.Content = channel.ChannelName;
            item.Tag = channel;
            target.Items.Add(item);
        }
        //Вспомогательные функции

        //Выводят список каналов/конфигов в заданный listview
        private void DisplayConfigList(ListView view, Channel configs)
        {
            if (configs != null) view.Items.Clear();
                foreach (var cfg in configs.Presets)
                {
                    AddPresetToListView(cfg, view);
                }
        }
        private bool DisplayChannelList(ListView view, string path)
        {
            try
            {
                ChannelsCollection list = XML.DeserializeXML(path);
                if (list != null) view.Items.Clear();
                foreach (var cfg in list.Channels)
                {
                    AddChannelToListView(cfg, view);
                }
                return true;
            }
            catch
            {
                view.Items.Clear();
                string message = App.Language.Name == "ru-RU" ? "Конфигурационный файл не найден или имеет некорректный формат" :
                    "The configuration file was not found or is not in the correct format";
                MessageBox.Show(message);
                return false;
            }
        }
        private void DisplayChannel(object sender, SelectionChangedEventArgs e)
        {
            if (ChannelLst.SelectedItems.Count == 1)
            {
                Channel cfg = (Channel)ChannelLst.SelectedItems.Cast<ListViewItem>().First().Tag;
                DisplayConfigList(PresetLst, cfg);
            }
        }

        //Отображение значений конфигурации в полях ввода
        private void DisplayConfig(object sender, MouseButtonEventArgs e)
        {
            var ctrl = (Controller)this.DataContext;

            if (PresetLst.SelectedItems.Count == 1)
            {
                Preset cfg = (Preset)PresetLst.SelectedItems.Cast<ListViewItem>().First().Tag;
                Copier.CopyValues(ctrl.InputData, cfg);
            }
        }
        private void DisplayConfig(object sender, SelectionChangedEventArgs e)
        {
            var ctrl = (Controller)this.DataContext;

            if (PresetLst.SelectedItems.Count == 1)
            {
                Preset cfg = (Preset)PresetLst.SelectedItems.Cast<ListViewItem>().First().Tag;
                Copier.CopyValues(ctrl.InputData, cfg);
            }
        }

        //Вызов формы для добавления конфига/канала
        private void CallFileReductorForm(object sender, RoutedEventArgs e)
        {
            ConfigEditor modal = new ConfigEditor(pathToPresets);
            modal.ShowDialog();
            InitPresets();
            PresetLst.Items.Clear();
        }

        //Проверки для сохранения конфигурации/канала

        //Если поля ввода пусты выводит 0
        private void CheckEmptyInput(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            string cleanText = textbox.Text.Replace(" ", string.Empty);
            textbox.Text = cleanText.Length != 0 ? cleanText : "0";
        }

    }
}

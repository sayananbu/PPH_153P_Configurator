﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            pathToPresets = "Presets.xml";
            DisplayChannelList(ChannelLst, pathToPresets);
        }
        string pathToPresets;
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
            PresetLst.SelectedItem = null;
            ChannelLst.SelectedItem = null;
        }

        //Закрытие потока
        private void MainWindow1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (this.DataContext as Controller).StopThread();
        }
        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            var controller = (Controller)this.DataContext;
            if (!controller.IsCANDeviceFound())
                MessageBox.Show("Утройство CAN не найдено");
            Copier.CopyValues(controller.InputData, controller.MainData);
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
        }

        //Открывает файл конфигурации и в дальнейшем записывает в него
        private void OpenFromFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                pathToPresets = dialog.FileName;
                DisplayChannelList(ChannelLst, pathToPresets);
                PresetLst.Items.Clear();
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
            chName.Text = configs.ChannelName;
            if (configs != null) view.Items.Clear();
                foreach (var cfg in configs.Presets)
                {
                    AddPresetToListView(cfg, view);
                }
        }
        private void DisplayChannelList(ListView view, string path)
        {
            try
            {
                ChannelsCollection list = XML.DeserializeXML(path);
                if (list != null) view.Items.Clear();
                foreach (var cfg in list.Channels)
                {
                    AddChannelToListView(cfg, view);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Конфигурационный файл не найден или имеет некорректный формат");
            }
        }
        //

        //Вывод списка конфигов выбранного канала
        private void DisplayChannel(object sender, SelectionChangedEventArgs e)
        {
            if (ChannelLst.SelectedItems.Count == 1)
            {
                Channel cfg = (Channel)ChannelLst.SelectedItems.Cast<ListViewItem>().First().Tag;
                chName.Text = cfg.ChannelName;
                DisplayConfigList(PresetLst, cfg);
            }
        }

        //Отображение значений конфигурации в полях ввода
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
        private void CallEnterNameForm(object sender, RoutedEventArgs e)
        {
            EnterPresetName modal = new EnterPresetName();
            try
            {
                modal.chans= XML.DeserializeXML(pathToPresets);
            }catch (Exception ex)
            {
            }
            modal.ShowDialog();
            if (modal.DialogResult == true)
            {
                SaveConfig(modal.chans,modal.chn, modal.prest);
            }
        }

        //Проверки для сохранения конфигурации/канала
        private void SaveConfig(ChannelsCollection collection ,Channel channel, Preset preset)
        {
            var ctrl = (Controller)this.DataContext;
            bool toAdd=true;
            Copier.CopyValues(preset, ctrl.InputData);
            channel.Presets.Add(preset);
            DisplayConfigList(PresetLst, channel);
            
            if (collection != null)
            {
                foreach(Channel ch in collection.Channels)
                {
                    if (ch.ChannelName == channel.ChannelName)
                    {
                        collection.Channels[collection.Channels.IndexOf(ch)] = channel;
                        toAdd = false;
                        break;
                    }
                }
                if (toAdd)
                {
                    collection.Channels.Add(channel);
                }
            }
            else
            {
                collection = new ChannelsCollection();
                collection.Channels.Add(channel);
            }
            XML.SerializeXML(collection, pathToPresets);
            DisplayChannelList(ChannelLst, pathToPresets);
        }

        //Если поля ввода пусты выводит 0
        private void CheckEmptyInput(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.Text.Length == 0)
            {
                textbox.Text = "0";
            }
        }

    }
}

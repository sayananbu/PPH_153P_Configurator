﻿#pragma checksum "..\..\..\Windows\ConfigEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D44E506A6893AAC7281DB6869CDB0094E9218189D16B526E72CAAE144270AD7C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PPH_153P_Configurator;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PPH_153P_Configurator {
    
    
    /// <summary>
    /// ConfigEditor
    /// </summary>
    public partial class ConfigEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 270 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cfgName;
        
        #line default
        #line hidden
        
        
        #line 279 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border PresetChoose;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PresetLst;
        
        #line default
        #line hidden
        
        
        #line 328 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chName;
        
        #line default
        #line hidden
        
        
        #line 338 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ChannelChoose;
        
        #line default
        #line hidden
        
        
        #line 349 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ChannelLst;
        
        #line default
        #line hidden
        
        
        #line 360 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border GeneralSettings;
        
        #line default
        #line hidden
        
        
        #line 448 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border SpecialSettings;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PPH_153P_Configurator;component/windows/configeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ConfigEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\Windows\ConfigEditor.xaml"
            ((PPH_153P_Configurator.ConfigEditor)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RedirectFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 58 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenFromFile);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 79 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateConfigFile);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 124 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveChanges);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 144 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteChannel);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 164 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewChannel);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 183 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewConfig);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 203 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteConfig);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 228 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveConfigFile);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cfgName = ((System.Windows.Controls.TextBox)(target));
            
            #line 276 "..\..\..\Windows\ConfigEditor.xaml"
            this.cfgName.LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyStringInput);
            
            #line default
            #line hidden
            return;
            case 12:
            this.PresetChoose = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            this.PresetLst = ((System.Windows.Controls.ListView)(target));
            
            #line 292 "..\..\..\Windows\ConfigEditor.xaml"
            this.PresetLst.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DisplayConfig);
            
            #line default
            #line hidden
            
            #line 292 "..\..\..\Windows\ConfigEditor.xaml"
            this.PresetLst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DisplayConfig);
            
            #line default
            #line hidden
            return;
            case 14:
            this.chName = ((System.Windows.Controls.TextBox)(target));
            
            #line 334 "..\..\..\Windows\ConfigEditor.xaml"
            this.chName.LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyStringInput);
            
            #line default
            #line hidden
            return;
            case 15:
            this.ChannelChoose = ((System.Windows.Controls.Border)(target));
            return;
            case 16:
            this.ChannelLst = ((System.Windows.Controls.ListView)(target));
            
            #line 352 "..\..\..\Windows\ConfigEditor.xaml"
            this.ChannelLst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DisplayChannel);
            
            #line default
            #line hidden
            
            #line 353 "..\..\..\Windows\ConfigEditor.xaml"
            this.ChannelLst.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DisplayChannel);
            
            #line default
            #line hidden
            return;
            case 17:
            this.GeneralSettings = ((System.Windows.Controls.Border)(target));
            return;
            case 18:
            
            #line 416 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckIntNumberInput);
            
            #line default
            #line hidden
            
            #line 416 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 426 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckIntNumberInput);
            
            #line default
            #line hidden
            
            #line 426 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 434 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 434 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 444 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 444 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 22:
            this.SpecialSettings = ((System.Windows.Controls.Border)(target));
            return;
            case 23:
            
            #line 487 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetFields);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 565 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 565 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 576 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 576 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 633 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 633 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 644 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 644 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 701 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 701 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 712 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 712 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 769 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 769 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 780 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 780 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


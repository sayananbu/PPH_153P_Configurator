﻿#pragma checksum "..\..\..\Windows\ConfigEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB82BA766DD8145A2E5E9AA40455D8E88041B733E63E9E92B0FED1B17C4E42F1"
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
        
        
        #line 12 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cfgName;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border PresetChoose;
        
        #line default
        #line hidden
        
        
        #line 262 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PresetLst;
        
        #line default
        #line hidden
        
        
        #line 297 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chName;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ChannelChoose;
        
        #line default
        #line hidden
        
        
        #line 318 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ChannelLst;
        
        #line default
        #line hidden
        
        
        #line 323 "..\..\..\Windows\ConfigEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border GeneralSettings;
        
        #line default
        #line hidden
        
        
        #line 411 "..\..\..\Windows\ConfigEditor.xaml"
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
            this.cfgName = ((System.Windows.Controls.TextBox)(target));
            
            #line 248 "..\..\..\Windows\ConfigEditor.xaml"
            this.cfgName.LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PresetChoose = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.PresetLst = ((System.Windows.Controls.ListView)(target));
            
            #line 263 "..\..\..\Windows\ConfigEditor.xaml"
            this.PresetLst.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DisplayConfig);
            
            #line default
            #line hidden
            
            #line 263 "..\..\..\Windows\ConfigEditor.xaml"
            this.PresetLst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DisplayConfig);
            
            #line default
            #line hidden
            return;
            case 6:
            this.chName = ((System.Windows.Controls.TextBox)(target));
            
            #line 303 "..\..\..\Windows\ConfigEditor.xaml"
            this.chName.LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ChannelChoose = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.ChannelLst = ((System.Windows.Controls.ListView)(target));
            
            #line 319 "..\..\..\Windows\ConfigEditor.xaml"
            this.ChannelLst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DisplayChannel);
            
            #line default
            #line hidden
            
            #line 319 "..\..\..\Windows\ConfigEditor.xaml"
            this.ChannelLst.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DisplayChannel);
            
            #line default
            #line hidden
            return;
            case 9:
            this.GeneralSettings = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            
            #line 379 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckIntNumberInput);
            
            #line default
            #line hidden
            
            #line 379 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 389 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckIntNumberInput);
            
            #line default
            #line hidden
            
            #line 389 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 397 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 397 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 407 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 407 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 14:
            this.SpecialSettings = ((System.Windows.Controls.Border)(target));
            return;
            case 15:
            
            #line 450 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetFields);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 528 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 528 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 539 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 539 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 596 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 596 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 607 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 607 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 664 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 664 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 675 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 675 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 732 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 732 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 743 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckFloatNumberInput);
            
            #line default
            #line hidden
            
            #line 743 "..\..\..\Windows\ConfigEditor.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.CheckEmptyInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

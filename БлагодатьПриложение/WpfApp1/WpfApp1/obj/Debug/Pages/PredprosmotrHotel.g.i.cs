﻿#pragma checksum "..\..\..\Pages\PredprosmotrHotel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7DDAD2AB67F8BAA7B419E1DFDD707E1AE525C9D833533136321951ADF127898E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1.Pages;


namespace WpfApp1.Pages {
    
    
    /// <summary>
    /// PredprosmotrHotel
    /// </summary>
    public partial class PredprosmotrHotel : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\PredprosmotrHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\PredprosmotrHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboType;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\PredprosmotrHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckActual;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\PredprosmotrHotel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVTours;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pages/predprosmotrhotel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PredprosmotrHotel.xaml"
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
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Pages\PredprosmotrHotel.xaml"
            this.SearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Pages\PredprosmotrHotel.xaml"
            this.ComboType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CheckActual = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\..\Pages\PredprosmotrHotel.xaml"
            this.CheckActual.Checked += new System.Windows.RoutedEventHandler(this.CheckActual_Checked);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\Pages\PredprosmotrHotel.xaml"
            this.CheckActual.Unchecked += new System.Windows.RoutedEventHandler(this.CheckActual_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LVTours = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


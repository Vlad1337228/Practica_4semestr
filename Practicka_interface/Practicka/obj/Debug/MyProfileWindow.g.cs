﻿#pragma checksum "..\..\MyProfileWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F2F85E3036DAB7F25D146BAE09FE8B451029841EF5D586514109A4B361690EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practicka;
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


namespace Practicka {
    
    
    /// <summary>
    /// MyProfileWindow
    /// </summary>
    public partial class MyProfileWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\MyProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelLogo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MyProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MyProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelEmail;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MyProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelvoucher;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MyProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listVoucher;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MyProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelNameUser;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MyProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelEmailUser;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MyProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateVoucher;
        
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
            System.Uri resourceLocater = new System.Uri("/Practicka;component/myprofilewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MyProfileWindow.xaml"
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
            this.labelLogo = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labelName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.labelEmail = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.labelvoucher = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            
            #line 36 "..\..\MyProfileWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listVoucher = ((System.Windows.Controls.ListBox)(target));
            
            #line 44 "..\..\MyProfileWindow.xaml"
            this.listVoucher.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listVoucher_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.labelNameUser = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.labelEmailUser = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.updateVoucher = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\MyProfileWindow.xaml"
            this.updateVoucher.Click += new System.Windows.RoutedEventHandler(this.updateVoucher_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


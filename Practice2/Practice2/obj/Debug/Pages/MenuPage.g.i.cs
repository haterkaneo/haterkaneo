﻿#pragma checksum "..\..\..\Pages\MenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "158D231A6193D270C59E55996DCDC0269A883F5B9112678E141971A4A7DAAB38"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practice2.Pages;
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


namespace Practice2.Pages {
    
    
    /// <summary>
    /// MenuPage
    /// </summary>
    public partial class MenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddItem;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BReadactItem;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDeleteItem;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BBack;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSort;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/Practice2;component/pages/menupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MenuPage.xaml"
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
            
            #line 10 "..\..\..\Pages\MenuPage.xaml"
            ((Practice2.Pages.MenuPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BAddItem = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\MenuPage.xaml"
            this.BAddItem.Click += new System.Windows.RoutedEventHandler(this.BAddItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BReadactItem = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\MenuPage.xaml"
            this.BReadactItem.Click += new System.Windows.RoutedEventHandler(this.BRedactItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BDeleteItem = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\MenuPage.xaml"
            this.BDeleteItem.Click += new System.Windows.RoutedEventHandler(this.BDeleteItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BBack = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\MenuPage.xaml"
            this.BBack.Click += new System.Windows.RoutedEventHandler(this.BBack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BSort = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\MenuPage.xaml"
            this.BSort.Click += new System.Windows.RoutedEventHandler(this.BSort_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DGInfo = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


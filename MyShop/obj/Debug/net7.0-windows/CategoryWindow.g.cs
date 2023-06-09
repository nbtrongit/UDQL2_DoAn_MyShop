﻿#pragma checksum "..\..\..\CategoryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4E2C99455D6070E2AC731386515329D0355C11B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyShop;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MyShop {
    
    
    /// <summary>
    /// CategoryWindow
    /// </summary>
    public partial class CategoryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\CategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addCategoryButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\CategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteCategoryButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\CategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateCategoryButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\CategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNewCategory;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\CategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxEditCategory;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CategoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CategorysListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyShop;component/categorywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CategoryWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\CategoryWindow.xaml"
            ((MyShop.CategoryWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addCategoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\CategoryWindow.xaml"
            this.addCategoryButton.Click += new System.Windows.RoutedEventHandler(this.addCategoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deleteCategoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\CategoryWindow.xaml"
            this.deleteCategoryButton.Click += new System.Windows.RoutedEventHandler(this.deleteCategoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.updateCategoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\CategoryWindow.xaml"
            this.updateCategoryButton.Click += new System.Windows.RoutedEventHandler(this.updateCategoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxNewCategory = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\CategoryWindow.xaml"
            this.textBoxNewCategory.MouseEnter += new System.Windows.Input.MouseEventHandler(this.textBoxNewCategory_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBoxEditCategory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CategorysListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            
            #line 43 "..\..\..\CategoryWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteMenu_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 48 "..\..\..\CategoryWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.editMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


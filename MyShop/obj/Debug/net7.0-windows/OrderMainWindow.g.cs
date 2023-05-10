﻿#pragma checksum "..\..\..\OrderMainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1EB001A2EEB52B03BB6EDDE2DC4C3352BA9FD36A"
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
    /// OrderMainWindow
    /// </summary>
    public partial class OrderMainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddOrder;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDeleteOrder;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUpdateOrder;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFilterDate;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxFirstDate;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxLastDate;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNewOrder;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pagingComboBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPrev;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonNext;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\OrderMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OrdersListView;
        
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
            System.Uri resourceLocater = new System.Uri("/MyShop;component/ordermainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OrderMainWindow.xaml"
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
            
            #line 8 "..\..\..\OrderMainWindow.xaml"
            ((MyShop.OrderMainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonAddOrder = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\OrderMainWindow.xaml"
            this.buttonAddOrder.Click += new System.Windows.RoutedEventHandler(this.buttonAddOrder_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonDeleteOrder = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\OrderMainWindow.xaml"
            this.buttonDeleteOrder.Click += new System.Windows.RoutedEventHandler(this.buttonDeleteOrder_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonUpdateOrder = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\OrderMainWindow.xaml"
            this.buttonUpdateOrder.Click += new System.Windows.RoutedEventHandler(this.buttonUpdateOrder_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonFilterDate = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\OrderMainWindow.xaml"
            this.buttonFilterDate.Click += new System.Windows.RoutedEventHandler(this.buttonFilterDate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBoxFirstDate = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\OrderMainWindow.xaml"
            this.textBoxFirstDate.MouseEnter += new System.Windows.Input.MouseEventHandler(this.textBoxFirstDate_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxLastDate = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\OrderMainWindow.xaml"
            this.textBoxLastDate.MouseEnter += new System.Windows.Input.MouseEventHandler(this.textBoxLastDate_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBoxNewOrder = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\OrderMainWindow.xaml"
            this.textBoxNewOrder.MouseEnter += new System.Windows.Input.MouseEventHandler(this.textBoxNewOrder_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 9:
            this.pagingComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\OrderMainWindow.xaml"
            this.pagingComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pagingComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonPrev = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\OrderMainWindow.xaml"
            this.buttonPrev.Click += new System.Windows.RoutedEventHandler(this.buttonPrev_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonNext = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\OrderMainWindow.xaml"
            this.buttonNext.Click += new System.Windows.RoutedEventHandler(this.buttonNext_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.OrdersListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 13:
            
            #line 70 "..\..\..\OrderMainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteMenu_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 75 "..\..\..\OrderMainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.editMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 15:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 88 "..\..\..\OrderMainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.listViewItem_DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

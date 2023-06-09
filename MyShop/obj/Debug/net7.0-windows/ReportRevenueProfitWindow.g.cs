﻿#pragma checksum "..\..\..\ReportRevenueProfitWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A31000DDC72171FD1A551E54C8C538607846E9DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
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
    /// ReportRevenueProfitWindow
    /// </summary>
    public partial class ReportRevenueProfitWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\ReportRevenueProfitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonReport;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ReportRevenueProfitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxFirstDate;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ReportRevenueProfitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxLastDate;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\ReportRevenueProfitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxNgay;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ReportRevenueProfitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxTuan;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ReportRevenueProfitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxThang;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ReportRevenueProfitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxNam;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\ReportRevenueProfitWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart chart;
        
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
            System.Uri resourceLocater = new System.Uri("/MyShop;component/reportrevenueprofitwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ReportRevenueProfitWindow.xaml"
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
            
            #line 9 "..\..\..\ReportRevenueProfitWindow.xaml"
            ((MyShop.ReportRevenueProfitWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonReport = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\ReportRevenueProfitWindow.xaml"
            this.buttonReport.Click += new System.Windows.RoutedEventHandler(this.buttonReport_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBoxFirstDate = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\ReportRevenueProfitWindow.xaml"
            this.textBoxFirstDate.MouseEnter += new System.Windows.Input.MouseEventHandler(this.textBoxFirstDate_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxLastDate = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\ReportRevenueProfitWindow.xaml"
            this.textBoxLastDate.MouseEnter += new System.Windows.Input.MouseEventHandler(this.textBoxLastDate_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.checkBoxNgay = ((System.Windows.Controls.CheckBox)(target));
            
            #line 17 "..\..\..\ReportRevenueProfitWindow.xaml"
            this.checkBoxNgay.Click += new System.Windows.RoutedEventHandler(this.checkBoxNgay_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.checkBoxTuan = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\..\ReportRevenueProfitWindow.xaml"
            this.checkBoxTuan.Click += new System.Windows.RoutedEventHandler(this.checkBoxTuan_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.checkBoxThang = ((System.Windows.Controls.CheckBox)(target));
            
            #line 19 "..\..\..\ReportRevenueProfitWindow.xaml"
            this.checkBoxThang.Click += new System.Windows.RoutedEventHandler(this.checkBoxThang_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkBoxNam = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\ReportRevenueProfitWindow.xaml"
            this.checkBoxNam.Click += new System.Windows.RoutedEventHandler(this.checkBoxNam_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.chart = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


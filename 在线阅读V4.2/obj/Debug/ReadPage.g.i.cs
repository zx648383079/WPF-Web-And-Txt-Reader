﻿#pragma checksum "..\..\ReadPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "22C4CE50CA2AE7925C0102A7DE489B7C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace 在线阅读 {
    
    
    /// <summary>
    /// ReadPage
    /// </summary>
    public partial class ReadPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ReadPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameLb;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ReadPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ChapterListBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ReadPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ContentTb;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\ReadPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTb;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ReadPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UrlTb;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\ReadPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BeforeBtn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\ReadPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/在线阅读;component/readpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReadPage.xaml"
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
            
            #line 8 "..\..\ReadPage.xaml"
            ((在线阅读.ReadPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameLb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ChapterListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            
            #line 24 "..\..\ReadPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 25 "..\..\ReadPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 26 "..\..\ReadPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ContentTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\ReadPage.xaml"
            this.ContentTb.KeyUp += new System.Windows.Input.KeyEventHandler(this.ContentTb_KeyUp);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 36 "..\..\ReadPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 37 "..\..\ReadPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 54 "..\..\ReadPage.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleTb_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TitleTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\ReadPage.xaml"
            this.TitleTb.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleTb_MouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.UrlTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\ReadPage.xaml"
            this.UrlTb.KeyDown += new System.Windows.Input.KeyEventHandler(this.UrlTb_KeyDown);
            
            #line default
            #line hidden
            
            #line 59 "..\..\ReadPage.xaml"
            this.UrlTb.LostFocus += new System.Windows.RoutedEventHandler(this.UrlTb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 13:
            this.BeforeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\ReadPage.xaml"
            this.BeforeBtn.Click += new System.Windows.RoutedEventHandler(this.BeforeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.NextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\ReadPage.xaml"
            this.NextBtn.Click += new System.Windows.RoutedEventHandler(this.NextBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


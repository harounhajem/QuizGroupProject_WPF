﻿#pragma checksum "..\..\..\..\View\_Shared\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A2C4CD0C051C61C943C14A7CB2D2FA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Quiz_WPFVersion;
using Quiz_WPFVersion.ViewModels;
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


namespace Quiz_WPFVersion {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\_Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid navMenu;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\_Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image menuLogo;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\_Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter gridSplitter;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\_Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSeeQuizzes;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\_Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateQuiz;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\View\_Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSendQuiz;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\View\_Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdministrate;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\View\_Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Quiz_WPFVersion;component/view/_shared/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\_Shared\MainWindow.xaml"
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
            this.navMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.menuLogo = ((System.Windows.Controls.Image)(target));
            
            #line 26 "..\..\..\..\View\_Shared\MainWindow.xaml"
            this.menuLogo.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gridSplitter = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 4:
            this.btnSeeQuizzes = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\View\_Shared\MainWindow.xaml"
            this.btnSeeQuizzes.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCreateQuiz = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\View\_Shared\MainWindow.xaml"
            this.btnCreateQuiz.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSendQuiz = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\View\_Shared\MainWindow.xaml"
            this.btnSendQuiz.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAdministrate = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\View\_Shared\MainWindow.xaml"
            this.btnAdministrate.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


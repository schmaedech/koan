﻿#pragma checksum "..\..\ChartPanel.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "347F449370200D96E681FF9E793ABF2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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


namespace BioSCADA {
    
    
    /// <summary>
    /// ChartPanel
    /// </summary>
    public partial class ChartPanel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ChartPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_tag;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\ChartPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_add_tag;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ChartPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Integration.WindowsFormsHost wfh_chart;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ChartPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider s_freq;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ChartPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider s_ampl;
        
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
            System.Uri resourceLocater = new System.Uri("/Koan;component/chartpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChartPanel.xaml"
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
            this.txt_tag = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.bt_add_tag = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\ChartPanel.xaml"
            this.bt_add_tag.Click += new System.Windows.RoutedEventHandler(this.bt_add_tag_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.wfh_chart = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 4:
            this.s_freq = ((System.Windows.Controls.Slider)(target));
            
            #line 14 "..\..\ChartPanel.xaml"
            this.s_freq.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.s_freq_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.s_ampl = ((System.Windows.Controls.Slider)(target));
            
            #line 15 "..\..\ChartPanel.xaml"
            this.s_ampl.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.s_ampl_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


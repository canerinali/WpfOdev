﻿#pragma checksum "..\..\..\View\Rezarvasyon.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C4AA6994B6DAAABC9EC593D2FF9AA3DE7FA9ED999B6711520D2093F3EC1D4E37"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HalisahaOdev.View;
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


namespace HalisahaOdev.View {
    
    
    /// <summary>
    /// Rezervasyon
    /// </summary>
    public partial class Rezervasyon : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\Rezarvasyon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_rezervasyon;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\Rezarvasyon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_rezervasyondescreption;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\Rezarvasyon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Tbl_Rezarvasyon;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\Rezarvasyon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_iptal;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\Rezarvasyon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbx_rezervasyon;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\Rezarvasyon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbx_Field;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\Rezarvasyon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_fieldsprice;
        
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
            System.Uri resourceLocater = new System.Uri("/HalisahaOdev;component/view/rezarvasyon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Rezarvasyon.xaml"
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
            
            #line 11 "..\..\..\View\Rezarvasyon.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_rezervasyon = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\View\Rezarvasyon.xaml"
            this.btn_rezervasyon.Click += new System.Windows.RoutedEventHandler(this.btn_rez_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_rezervasyondescreption = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Tbl_Rezarvasyon = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btn_iptal = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\View\Rezarvasyon.xaml"
            this.btn_iptal.Click += new System.Windows.RoutedEventHandler(this.btn_iptal_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbx_rezervasyon = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\..\View\Rezarvasyon.xaml"
            this.cmbx_rezervasyon.Loaded += new System.Windows.RoutedEventHandler(this.cmbx_rezervasyon_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbx_Field = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\View\Rezarvasyon.xaml"
            this.cmbx_Field.Loaded += new System.Windows.RoutedEventHandler(this.cmbx_Field_Loaded);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\View\Rezarvasyon.xaml"
            this.cmbx_Field.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbx_Field_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tb_fieldsprice = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\..\Fakta\FProgram.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AEBA8B8FD06C7235C2515FEEB0F75BE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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


namespace BAPPEDADW.Fakta {
    
    
    /// <summary>
    /// FProgram
    /// </summary>
    public partial class FProgram : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Fakta\FProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listFprogram;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Fakta\FProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bAwal;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Fakta\FProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bPrev;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Fakta\FProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PageNum;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Fakta\FProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bNext;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Fakta\FProgram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bAkhir;
        
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
            System.Uri resourceLocater = new System.Uri("/BAPPEDADW;component/fakta/fprogram.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Fakta\FProgram.xaml"
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
            
            #line 9 "..\..\..\Fakta\FProgram.xaml"
            ((BAPPEDADW.Fakta.FProgram)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listFprogram = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.bAwal = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Fakta\FProgram.xaml"
            this.bAwal.Click += new System.Windows.RoutedEventHandler(this.bAwal_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bPrev = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Fakta\FProgram.xaml"
            this.bPrev.Click += new System.Windows.RoutedEventHandler(this.bPrev_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PageNum = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.bNext = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Fakta\FProgram.xaml"
            this.bNext.Click += new System.Windows.RoutedEventHandler(this.bNext_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bAkhir = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Fakta\FProgram.xaml"
            this.bAkhir.Click += new System.Windows.RoutedEventHandler(this.bAkhir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


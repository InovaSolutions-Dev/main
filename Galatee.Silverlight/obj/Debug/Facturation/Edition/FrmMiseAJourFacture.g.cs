﻿#pragma checksum "D:\EDEN\EDMSA\iWEBS_EDMSA\Galatee.Silverlight\Facturation\Edition\FrmMiseAJourFacture.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D75D1C469E0F8326ED10319CC0F5C9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SilverlightContrib.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Galatee.Silverlight.Facturation {
    
    
    public partial class FrmMiseAJourFacture : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy1;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DataGrid dtgFactures;
        
        internal System.Windows.Controls.ProgressBar prgBar;
        
        internal System.Windows.Controls.Button btn_fermer;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Facturation/Edition/FrmMiseAJourFacture.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.groupBox1_Copy1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy1")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.dtgFactures = ((System.Windows.Controls.DataGrid)(this.FindName("dtgFactures")));
            this.prgBar = ((System.Windows.Controls.ProgressBar)(this.FindName("prgBar")));
            this.btn_fermer = ((System.Windows.Controls.Button)(this.FindName("btn_fermer")));
        }
    }
}

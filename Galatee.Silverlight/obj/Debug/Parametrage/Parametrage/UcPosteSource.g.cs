﻿#pragma checksum "D:\EDEN\EDMSA\iWEBS_EDMSA\Galatee.Silverlight\Parametrage\Parametrage\UcPosteSource.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6C03F2975568B58E7C00E5E9AA21E216"
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


namespace Galatee.Silverlight.Parametrage {
    
    
    public partial class UcPosteSource : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ProgressBar progressBar1;
        
        internal System.Windows.Controls.Label lab_Code;
        
        internal System.Windows.Controls.TextBox Txt_Code;
        
        internal System.Windows.Controls.Label lab_Libelle;
        
        internal System.Windows.Controls.TextBox Txt_Libelle;
        
        internal System.Windows.Controls.Label lab_Commune;
        
        internal System.Windows.Controls.ComboBox Cbo_Commune;
        
        internal System.Windows.Controls.Button btnOk;
        
        internal System.Windows.Controls.Button Btn_Reinitialiser;
        
        internal SilverlightContrib.Controls.GroupBox GboPosteSource;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/Parametrage/UcPosteSource.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.progressBar1 = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar1")));
            this.lab_Code = ((System.Windows.Controls.Label)(this.FindName("lab_Code")));
            this.Txt_Code = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Code")));
            this.lab_Libelle = ((System.Windows.Controls.Label)(this.FindName("lab_Libelle")));
            this.Txt_Libelle = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Libelle")));
            this.lab_Commune = ((System.Windows.Controls.Label)(this.FindName("lab_Commune")));
            this.Cbo_Commune = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Commune")));
            this.btnOk = ((System.Windows.Controls.Button)(this.FindName("btnOk")));
            this.Btn_Reinitialiser = ((System.Windows.Controls.Button)(this.FindName("Btn_Reinitialiser")));
            this.GboPosteSource = ((SilverlightContrib.Controls.GroupBox)(this.FindName("GboPosteSource")));
        }
    }
}


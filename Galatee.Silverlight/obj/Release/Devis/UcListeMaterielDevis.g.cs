﻿#pragma checksum "E:\DOCUMENTATION\EDMSA\LIVRAISON 2021 02 15 - SPRINT 2\SPRINT 2\iWEBS_EDMSA\Galatee.Silverlight\Devis\UcListeMaterielDevis.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FBE9398073687C4B08F1F65FA62995B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Galatee.Silverlight.Library;
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


namespace Galatee.Silverlight.Devis {
    
    
    public partial class UcListeMaterielDevis : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DataGrid dataGridElementDevis;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationAccount;
        
        internal System.Windows.Controls.TextBox txt_CodeMateriel;
        
        internal System.Windows.Controls.TextBox txt_LibelleMateriel;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.Label label1_Copy;
        
        internal System.Windows.Controls.Label label1_Copy1;
        
        internal Galatee.Silverlight.Library.NumericTextBox Txt_Nombre;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Devis/UcListeMaterielDevis.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.dataGridElementDevis = ((System.Windows.Controls.DataGrid)(this.FindName("dataGridElementDevis")));
            this.Gbo_InformationAccount = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationAccount")));
            this.txt_CodeMateriel = ((System.Windows.Controls.TextBox)(this.FindName("txt_CodeMateriel")));
            this.txt_LibelleMateriel = ((System.Windows.Controls.TextBox)(this.FindName("txt_LibelleMateriel")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.label1_Copy = ((System.Windows.Controls.Label)(this.FindName("label1_Copy")));
            this.label1_Copy1 = ((System.Windows.Controls.Label)(this.FindName("label1_Copy1")));
            this.Txt_Nombre = ((Galatee.Silverlight.Library.NumericTextBox)(this.FindName("Txt_Nombre")));
        }
    }
}


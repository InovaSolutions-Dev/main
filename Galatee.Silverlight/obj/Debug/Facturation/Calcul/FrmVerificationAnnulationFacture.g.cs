﻿#pragma checksum "D:\EDEN\EDMSA\iWEBS_EDMSA\Galatee.Silverlight\Facturation\Calcul\FrmVerificationAnnulationFacture.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DA02DD9F16367493F4A1FB955ED0A269"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class FrmVerificationAnnulationFacture : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DataGrid dtg_DetailFacture;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.Label label2;
        
        internal System.Windows.Controls.TextBox txtClient;
        
        internal System.Windows.Controls.Label label3;
        
        internal System.Windows.Controls.TextBox txtOrdre;
        
        internal System.Windows.Controls.Label label4;
        
        internal System.Windows.Controls.Label label5;
        
        internal System.Windows.Controls.TextBox txtNom;
        
        internal System.Windows.Controls.ComboBox cmbFacture;
        
        internal System.Windows.Controls.RadioButton rdb_Periode;
        
        internal System.Windows.Controls.Label label4_Copy;
        
        internal System.Windows.Controls.Label label4_Copy1;
        
        internal System.Windows.Controls.Label lbl_Centre;
        
        internal System.Windows.Controls.TextBox Txt_CodeCentre;
        
        internal System.Windows.Controls.Button btn_Centre;
        
        internal System.Windows.Controls.Label lbl_Centre_Copy;
        
        internal System.Windows.Controls.TextBox Txt_CodeSite;
        
        internal System.Windows.Controls.TextBox Txt_LibelleSite;
        
        internal System.Windows.Controls.Button btn_Site;
        
        internal System.Windows.Controls.TextBox Txt_LibelleCentre;
        
        internal System.Windows.Controls.ProgressBar prgBar;
        
        internal System.Windows.Controls.CheckBox chk_Quitance;
        
        internal System.Windows.Controls.Label label2_Copy;
        
        internal System.Windows.Controls.TextBox txtMotifDemande;
        
        internal System.Windows.Controls.Label labMotifRejet;
        
        internal System.Windows.Controls.TextBox txtMotifRejet;
        
        internal System.Windows.Controls.Label lbl_Centre_Copy1;
        
        internal System.Windows.Controls.TextBox TxtDemande;
        
        internal System.Windows.Controls.Button btnRejeter;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Facturation/Calcul/FrmVerificationAnnulationFactur" +
                        "e.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.dtg_DetailFacture = ((System.Windows.Controls.DataGrid)(this.FindName("dtg_DetailFacture")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.label2 = ((System.Windows.Controls.Label)(this.FindName("label2")));
            this.txtClient = ((System.Windows.Controls.TextBox)(this.FindName("txtClient")));
            this.label3 = ((System.Windows.Controls.Label)(this.FindName("label3")));
            this.txtOrdre = ((System.Windows.Controls.TextBox)(this.FindName("txtOrdre")));
            this.label4 = ((System.Windows.Controls.Label)(this.FindName("label4")));
            this.label5 = ((System.Windows.Controls.Label)(this.FindName("label5")));
            this.txtNom = ((System.Windows.Controls.TextBox)(this.FindName("txtNom")));
            this.cmbFacture = ((System.Windows.Controls.ComboBox)(this.FindName("cmbFacture")));
            this.rdb_Periode = ((System.Windows.Controls.RadioButton)(this.FindName("rdb_Periode")));
            this.label4_Copy = ((System.Windows.Controls.Label)(this.FindName("label4_Copy")));
            this.label4_Copy1 = ((System.Windows.Controls.Label)(this.FindName("label4_Copy1")));
            this.lbl_Centre = ((System.Windows.Controls.Label)(this.FindName("lbl_Centre")));
            this.Txt_CodeCentre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeCentre")));
            this.btn_Centre = ((System.Windows.Controls.Button)(this.FindName("btn_Centre")));
            this.lbl_Centre_Copy = ((System.Windows.Controls.Label)(this.FindName("lbl_Centre_Copy")));
            this.Txt_CodeSite = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeSite")));
            this.Txt_LibelleSite = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleSite")));
            this.btn_Site = ((System.Windows.Controls.Button)(this.FindName("btn_Site")));
            this.Txt_LibelleCentre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleCentre")));
            this.prgBar = ((System.Windows.Controls.ProgressBar)(this.FindName("prgBar")));
            this.chk_Quitance = ((System.Windows.Controls.CheckBox)(this.FindName("chk_Quitance")));
            this.label2_Copy = ((System.Windows.Controls.Label)(this.FindName("label2_Copy")));
            this.txtMotifDemande = ((System.Windows.Controls.TextBox)(this.FindName("txtMotifDemande")));
            this.labMotifRejet = ((System.Windows.Controls.Label)(this.FindName("labMotifRejet")));
            this.txtMotifRejet = ((System.Windows.Controls.TextBox)(this.FindName("txtMotifRejet")));
            this.lbl_Centre_Copy1 = ((System.Windows.Controls.Label)(this.FindName("lbl_Centre_Copy1")));
            this.TxtDemande = ((System.Windows.Controls.TextBox)(this.FindName("TxtDemande")));
            this.btnRejeter = ((System.Windows.Controls.Button)(this.FindName("btnRejeter")));
        }
    }
}


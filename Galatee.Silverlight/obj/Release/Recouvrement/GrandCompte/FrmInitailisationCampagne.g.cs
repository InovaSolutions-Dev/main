﻿#pragma checksum "E:\DOCUMENTATION\EDMSA\LIVRAISON 2021 02 15 - SPRINT 2\SPRINT 2\iWEBS_EDMSA\Galatee.Silverlight\Recouvrement\GrandCompte\FrmInitailisationCampagne.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "17CAA628BD41A89049FE2D468264116C"
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


namespace Galatee.Silverlight.Recouvrement {
    
    
    public partial class FrmInitailisationCampagne : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy1;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy2;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.ComboBox cbo_regroupement;
        
        internal System.Windows.Controls.TextBox txt_periode;
        
        internal System.Windows.Controls.DataGrid dg_facture;
        
        internal System.Windows.Controls.Button Charger;
        
        internal System.Windows.Controls.Button Decharger;
        
        internal System.Windows.Controls.Button btn_Rech;
        
        internal System.Windows.Controls.Button btn_ajouterPeriod;
        
        internal System.Windows.Controls.Button btn_supp;
        
        internal System.Windows.Controls.ProgressBar progressBar1;
        
        internal System.Windows.Controls.ListBox lbx_Periode;
        
        internal System.Windows.Controls.Button btn_ajouterFactureHorReg;
        
        internal System.Windows.Controls.DataGrid dg_facture_Copy;
        
        internal System.Windows.Controls.DataPager datapager;
        
        internal System.Windows.Controls.DataPager datapager_Copy;
        
        internal System.Windows.Controls.Button btn_ajouterFactureHorReg_Copy;
        
        internal System.Windows.Controls.TextBox txt_TotalFacture;
        
        internal System.Windows.Controls.TextBox txt_TotalFactureEnvoie;
        
        internal System.Windows.Controls.Button btn_DeChargerTout;
        
        internal System.Windows.Controls.Button btn_ChargerTout;
        
        internal System.Windows.Controls.TextBox txt_periode_Fin;
        
        internal System.Windows.Controls.Label lbl_Periode_Fin;
        
        internal System.Windows.Controls.Label lbl_Periode_debut;
        
        internal System.Windows.Controls.TextBox txt_periode_Debut;
        
        internal System.Windows.Controls.CheckBox chb_PlagePeriode;
        
        internal System.Windows.Controls.CheckBox Chk_MT;
        
        internal System.Windows.Controls.CheckBox Chk_BT;
        
        internal System.Windows.Controls.CheckBox chb_AvisDeCredit;
        
        internal System.Windows.Controls.TextBox txt_Regroupement;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Recouvrement/GrandCompte/FrmInitailisationCampagne" +
                        ".xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.groupBox1_Copy = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy")));
            this.groupBox1_Copy1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy1")));
            this.groupBox1_Copy2 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy2")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.cbo_regroupement = ((System.Windows.Controls.ComboBox)(this.FindName("cbo_regroupement")));
            this.txt_periode = ((System.Windows.Controls.TextBox)(this.FindName("txt_periode")));
            this.dg_facture = ((System.Windows.Controls.DataGrid)(this.FindName("dg_facture")));
            this.Charger = ((System.Windows.Controls.Button)(this.FindName("Charger")));
            this.Decharger = ((System.Windows.Controls.Button)(this.FindName("Decharger")));
            this.btn_Rech = ((System.Windows.Controls.Button)(this.FindName("btn_Rech")));
            this.btn_ajouterPeriod = ((System.Windows.Controls.Button)(this.FindName("btn_ajouterPeriod")));
            this.btn_supp = ((System.Windows.Controls.Button)(this.FindName("btn_supp")));
            this.progressBar1 = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar1")));
            this.lbx_Periode = ((System.Windows.Controls.ListBox)(this.FindName("lbx_Periode")));
            this.btn_ajouterFactureHorReg = ((System.Windows.Controls.Button)(this.FindName("btn_ajouterFactureHorReg")));
            this.dg_facture_Copy = ((System.Windows.Controls.DataGrid)(this.FindName("dg_facture_Copy")));
            this.datapager = ((System.Windows.Controls.DataPager)(this.FindName("datapager")));
            this.datapager_Copy = ((System.Windows.Controls.DataPager)(this.FindName("datapager_Copy")));
            this.btn_ajouterFactureHorReg_Copy = ((System.Windows.Controls.Button)(this.FindName("btn_ajouterFactureHorReg_Copy")));
            this.txt_TotalFacture = ((System.Windows.Controls.TextBox)(this.FindName("txt_TotalFacture")));
            this.txt_TotalFactureEnvoie = ((System.Windows.Controls.TextBox)(this.FindName("txt_TotalFactureEnvoie")));
            this.btn_DeChargerTout = ((System.Windows.Controls.Button)(this.FindName("btn_DeChargerTout")));
            this.btn_ChargerTout = ((System.Windows.Controls.Button)(this.FindName("btn_ChargerTout")));
            this.txt_periode_Fin = ((System.Windows.Controls.TextBox)(this.FindName("txt_periode_Fin")));
            this.lbl_Periode_Fin = ((System.Windows.Controls.Label)(this.FindName("lbl_Periode_Fin")));
            this.lbl_Periode_debut = ((System.Windows.Controls.Label)(this.FindName("lbl_Periode_debut")));
            this.txt_periode_Debut = ((System.Windows.Controls.TextBox)(this.FindName("txt_periode_Debut")));
            this.chb_PlagePeriode = ((System.Windows.Controls.CheckBox)(this.FindName("chb_PlagePeriode")));
            this.Chk_MT = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_MT")));
            this.Chk_BT = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_BT")));
            this.chb_AvisDeCredit = ((System.Windows.Controls.CheckBox)(this.FindName("chb_AvisDeCredit")));
            this.txt_Regroupement = ((System.Windows.Controls.TextBox)(this.FindName("txt_Regroupement")));
        }
    }
}


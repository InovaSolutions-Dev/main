﻿#pragma checksum "D:\TFS_SOURCE_EDM\iWEBS_EDMSA\Galatee.Silverlight\Fraude\UcFacturation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EEE31176D2D359055E7241291A13C4A8"
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


namespace Galatee.Silverlight.Fraude {
    
    
    public partial class UcFacturation : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_MontnatPrese_Copy;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_MontnatPrese_Copy1;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_MontnatConso_Copy;
        
        internal System.Windows.Controls.TextBox txtConsommationEstimee;
        
        internal System.Windows.Controls.TextBox txtNbreMois;
        
        internal System.Windows.Controls.TextBox txtConsommationMensuelle;
        
        internal System.Windows.Controls.TextBox txtConsommationDejaFacturee;
        
        internal System.Windows.Controls.TextBox txtTaxe;
        
        internal System.Windows.Controls.TextBox txtConsommationAFacturer;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_MontnatConso;
        
        internal System.Windows.Controls.DataGrid dtgrdTrancheFrd;
        
        internal System.Windows.Controls.TextBox txtMontantHTConsommationMensuelle;
        
        internal System.Windows.Controls.TextBox txtMontantHTConsommationAnnuelle;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_MontnatPrese;
        
        internal System.Windows.Controls.DataGrid dtgrdPrestEDM;
        
        internal System.Windows.Controls.TextBox txtMontantHTPrestation;
        
        internal System.Windows.Controls.DataGrid dtgrdPrestRemboursmnt;
        
        internal System.Windows.Controls.TextBox txtMontantHTPrestationRemboursable;
        
        internal System.Windows.Controls.DataGrid dtgrdPrestRegulation;
        
        internal System.Windows.Controls.TextBox txtTotalFactureTTC;
        
        internal System.Windows.Controls.Label lblForfait;
        
        internal System.Windows.Controls.TextBox txtMontantForfait;
        
        internal System.Windows.Controls.TextBox txtMontantHTRegularisation;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Fraude/UcFacturation.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Gbo_MontnatPrese_Copy = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_MontnatPrese_Copy")));
            this.Gbo_MontnatPrese_Copy1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_MontnatPrese_Copy1")));
            this.Gbo_MontnatConso_Copy = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_MontnatConso_Copy")));
            this.txtConsommationEstimee = ((System.Windows.Controls.TextBox)(this.FindName("txtConsommationEstimee")));
            this.txtNbreMois = ((System.Windows.Controls.TextBox)(this.FindName("txtNbreMois")));
            this.txtConsommationMensuelle = ((System.Windows.Controls.TextBox)(this.FindName("txtConsommationMensuelle")));
            this.txtConsommationDejaFacturee = ((System.Windows.Controls.TextBox)(this.FindName("txtConsommationDejaFacturee")));
            this.txtTaxe = ((System.Windows.Controls.TextBox)(this.FindName("txtTaxe")));
            this.txtConsommationAFacturer = ((System.Windows.Controls.TextBox)(this.FindName("txtConsommationAFacturer")));
            this.Gbo_MontnatConso = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_MontnatConso")));
            this.dtgrdTrancheFrd = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdTrancheFrd")));
            this.txtMontantHTConsommationMensuelle = ((System.Windows.Controls.TextBox)(this.FindName("txtMontantHTConsommationMensuelle")));
            this.txtMontantHTConsommationAnnuelle = ((System.Windows.Controls.TextBox)(this.FindName("txtMontantHTConsommationAnnuelle")));
            this.Gbo_MontnatPrese = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_MontnatPrese")));
            this.dtgrdPrestEDM = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdPrestEDM")));
            this.txtMontantHTPrestation = ((System.Windows.Controls.TextBox)(this.FindName("txtMontantHTPrestation")));
            this.dtgrdPrestRemboursmnt = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdPrestRemboursmnt")));
            this.txtMontantHTPrestationRemboursable = ((System.Windows.Controls.TextBox)(this.FindName("txtMontantHTPrestationRemboursable")));
            this.dtgrdPrestRegulation = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdPrestRegulation")));
            this.txtTotalFactureTTC = ((System.Windows.Controls.TextBox)(this.FindName("txtTotalFactureTTC")));
            this.lblForfait = ((System.Windows.Controls.Label)(this.FindName("lblForfait")));
            this.txtMontantForfait = ((System.Windows.Controls.TextBox)(this.FindName("txtMontantForfait")));
            this.txtMontantHTRegularisation = ((System.Windows.Controls.TextBox)(this.FindName("txtMontantHTRegularisation")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
        }
    }
}


﻿#pragma checksum "D:\EDEN\EDMSA\iWEBS_EDMSA\Galatee.Silverlight\Caisse\FrmDuplicatEncaissement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D858BCF4B4CCD775290A9A9D652A2760"
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


namespace Galatee.Silverlight.Caisse {
    
    
    public partial class FrmDuplicatEncaissement : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.ComboBox Cbo_ListeRecu;
        
        internal System.Windows.Controls.Label lbl_Recu;
        
        internal System.Windows.Controls.Label lbl_MontantTotRecu;
        
        internal System.Windows.Controls.TextBox txtMontantRecuTot;
        
        internal System.Windows.Controls.DataGrid dtg_FactureAnnule;
        
        internal System.Windows.Controls.CheckBox Chk_BorderoSeulement;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Caisse/FrmDuplicatEncaissement.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.Cbo_ListeRecu = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_ListeRecu")));
            this.lbl_Recu = ((System.Windows.Controls.Label)(this.FindName("lbl_Recu")));
            this.lbl_MontantTotRecu = ((System.Windows.Controls.Label)(this.FindName("lbl_MontantTotRecu")));
            this.txtMontantRecuTot = ((System.Windows.Controls.TextBox)(this.FindName("txtMontantRecuTot")));
            this.dtg_FactureAnnule = ((System.Windows.Controls.DataGrid)(this.FindName("dtg_FactureAnnule")));
            this.Chk_BorderoSeulement = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_BorderoSeulement")));
        }
    }
}


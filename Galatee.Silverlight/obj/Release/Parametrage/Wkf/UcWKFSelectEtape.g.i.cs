﻿#pragma checksum "D:\TFS_SOURCE_EDM\iWEBS_EDMSA\Galatee.Silverlight\Parametrage\Wkf\UcWKFSelectEtape.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E00C97373C99260B7C0FBB644CCF2AD1"
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
    
    
    public partial class UcWKFSelectEtape : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox GroupBox;
        
        internal System.Windows.Controls.ComboBox cmbEtape;
        
        internal System.Windows.Controls.Label lblCondition;
        
        internal System.Windows.Controls.TextBox txtCondition;
        
        internal System.Windows.Controls.ComboBox cmbGroupeValidation;
        
        internal System.Windows.Controls.TextBox txtEtapePrecedente;
        
        internal System.Windows.Controls.HyperlinkButton HPLSupprime;
        
        internal System.Windows.Controls.Label lblCondition_Copy;
        
        internal System.Windows.Controls.TextBox txtDelai;
        
        internal System.Windows.Controls.Label lblCondition_Copy1;
        
        internal SilverlightContrib.Controls.GroupBox GroupBoxdtGrid;
        
        internal System.Windows.Controls.DataGrid dtgrdParametre;
        
        internal System.Windows.Controls.ContextMenu MenuContextuel;
        
        internal System.Windows.Controls.MenuItem MenuContextuelCreerEtape;
        
        internal System.Windows.Controls.MenuItem MenuContextuelModifier;
        
        internal System.Windows.Controls.MenuItem MenuContextuelSupprimer;
        
        internal System.Windows.Controls.Button BtnSuppRejet;
        
        internal System.Windows.Controls.Button BtnAjouterRejet;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/Wkf/UcWKFSelectEtape.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.GroupBox = ((SilverlightContrib.Controls.GroupBox)(this.FindName("GroupBox")));
            this.cmbEtape = ((System.Windows.Controls.ComboBox)(this.FindName("cmbEtape")));
            this.lblCondition = ((System.Windows.Controls.Label)(this.FindName("lblCondition")));
            this.txtCondition = ((System.Windows.Controls.TextBox)(this.FindName("txtCondition")));
            this.cmbGroupeValidation = ((System.Windows.Controls.ComboBox)(this.FindName("cmbGroupeValidation")));
            this.txtEtapePrecedente = ((System.Windows.Controls.TextBox)(this.FindName("txtEtapePrecedente")));
            this.HPLSupprime = ((System.Windows.Controls.HyperlinkButton)(this.FindName("HPLSupprime")));
            this.lblCondition_Copy = ((System.Windows.Controls.Label)(this.FindName("lblCondition_Copy")));
            this.txtDelai = ((System.Windows.Controls.TextBox)(this.FindName("txtDelai")));
            this.lblCondition_Copy1 = ((System.Windows.Controls.Label)(this.FindName("lblCondition_Copy1")));
            this.GroupBoxdtGrid = ((SilverlightContrib.Controls.GroupBox)(this.FindName("GroupBoxdtGrid")));
            this.dtgrdParametre = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdParametre")));
            this.MenuContextuel = ((System.Windows.Controls.ContextMenu)(this.FindName("MenuContextuel")));
            this.MenuContextuelCreerEtape = ((System.Windows.Controls.MenuItem)(this.FindName("MenuContextuelCreerEtape")));
            this.MenuContextuelModifier = ((System.Windows.Controls.MenuItem)(this.FindName("MenuContextuelModifier")));
            this.MenuContextuelSupprimer = ((System.Windows.Controls.MenuItem)(this.FindName("MenuContextuelSupprimer")));
            this.BtnSuppRejet = ((System.Windows.Controls.Button)(this.FindName("BtnSuppRejet")));
            this.BtnAjouterRejet = ((System.Windows.Controls.Button)(this.FindName("BtnAjouterRejet")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
        }
    }
}


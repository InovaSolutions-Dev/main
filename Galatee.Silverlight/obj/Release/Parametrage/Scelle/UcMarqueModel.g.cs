﻿#pragma checksum "E:\DOCUMENTATION\EDMSA\LIVRAISON 2021 02 15 - SPRINT 2\SPRINT 2\iWEBS_EDMSA\Galatee.Silverlight\Parametrage\Scelle\UcMarqueModel.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B3CB987C99C9E6134627D034BE353A86"
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
    
    
    public partial class UcMarqueModel : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationDevis;
        
        internal System.Windows.Controls.TextBox txt_NombreScelleCache;
        
        internal System.Windows.Controls.ComboBox Cbo_Produit;
        
        internal System.Windows.Controls.ComboBox Cbo_Marque;
        
        internal System.Windows.Controls.ComboBox Cbo_Modele;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.TextBox txt_nbreScelleCapot;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/Scelle/UcMarqueModel.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Gbo_InformationDevis = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationDevis")));
            this.txt_NombreScelleCache = ((System.Windows.Controls.TextBox)(this.FindName("txt_NombreScelleCache")));
            this.Cbo_Produit = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Produit")));
            this.Cbo_Marque = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Marque")));
            this.Cbo_Modele = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Modele")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.txt_nbreScelleCapot = ((System.Windows.Controls.TextBox)(this.FindName("txt_nbreScelleCapot")));
        }
    }
}


﻿#pragma checksum "E:\EDEN\EDMSA\iWEBS_EDMSA\Galatee.Silverlight\Caisse\FrmDemandeTimbre.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ADF739A9BC3A083C47B402A5C5BEA235"
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


namespace Galatee.Silverlight.Caisse {
    
    
    public partial class FrmDemandeTimbre : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy1;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.Button btn_Transmetre;
        
        internal System.Windows.Controls.ComboBox cbo_TypeTimbre;
        
        internal System.Windows.Controls.TextBox Txt_Nombre;
        
        internal System.Windows.Controls.Button btn_Ajouter;
        
        internal System.Windows.Controls.DataGrid dtg_EtatCaisse;
        
        internal System.Windows.Controls.TextBox Txt_Montant;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_PieceJointe;
        
        internal System.Windows.Controls.DataGrid dgListePiece;
        
        internal System.Windows.Controls.Button btn_ajoutpiece;
        
        internal System.Windows.Controls.Button btn_supprimerpiece;
        
        internal System.Windows.Controls.ComboBox cbo_typedoc;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Caisse/FrmDemandeTimbre.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.groupBox1_Copy1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy1")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.btn_Transmetre = ((System.Windows.Controls.Button)(this.FindName("btn_Transmetre")));
            this.cbo_TypeTimbre = ((System.Windows.Controls.ComboBox)(this.FindName("cbo_TypeTimbre")));
            this.Txt_Nombre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Nombre")));
            this.btn_Ajouter = ((System.Windows.Controls.Button)(this.FindName("btn_Ajouter")));
            this.dtg_EtatCaisse = ((System.Windows.Controls.DataGrid)(this.FindName("dtg_EtatCaisse")));
            this.Txt_Montant = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Montant")));
            this.Gbo_PieceJointe = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_PieceJointe")));
            this.dgListePiece = ((System.Windows.Controls.DataGrid)(this.FindName("dgListePiece")));
            this.btn_ajoutpiece = ((System.Windows.Controls.Button)(this.FindName("btn_ajoutpiece")));
            this.btn_supprimerpiece = ((System.Windows.Controls.Button)(this.FindName("btn_supprimerpiece")));
            this.cbo_typedoc = ((System.Windows.Controls.ComboBox)(this.FindName("cbo_typedoc")));
        }
    }
}


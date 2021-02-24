﻿#pragma checksum "E:\DOCUMENTATION\EDMSA\LIVRAISON 2021 02 15 - SPRINT 2\SPRINT 2\iWEBS_EDMSA\Galatee.Silverlight\Devis\UcCalculFactureClient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9789740670A6C54D3B18DBD9C9B2EAF8"
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


namespace Galatee.Silverlight.Devis {
    
    
    public partial class UcCalculFactureClient : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.TabControl tabControl_Consultation;
        
        internal System.Windows.Controls.TabItem tabItemDevis;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationDevis;
        
        internal System.Windows.Controls.TextBox Txt_NumeroDevis;
        
        internal System.Windows.Controls.Label lbl_Devis;
        
        internal System.Windows.Controls.TextBox Txt_Ordre;
        
        internal System.Windows.Controls.TextBox Txt_CodeSite;
        
        internal System.Windows.Controls.Label lbl_Site;
        
        internal System.Windows.Controls.TextBox Txt_LibelleSite;
        
        internal System.Windows.Controls.TextBox Txt_CodeCentre;
        
        internal System.Windows.Controls.Label lbl_Centre;
        
        internal System.Windows.Controls.TextBox Txt_LibelleCentre;
        
        internal System.Windows.Controls.TextBox Txt_LibelleProduit;
        
        internal System.Windows.Controls.Label lbl_Produit;
        
        internal System.Windows.Controls.TextBox Txt_CodeProduit;
        
        internal System.Windows.Controls.TextBox Txt_LibelleTypeDevis;
        
        internal System.Windows.Controls.TextBox Txt_EtapeCourante;
        
        internal System.Windows.Controls.TextBox Txt_EtapeSuivante;
        
        internal System.Windows.Controls.Label lbl_TypeDevis;
        
        internal System.Windows.Controls.Label lbl_EtapeEnCours;
        
        internal System.Windows.Controls.Label lbl_EtapeSuivante;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_PieceJointe;
        
        internal System.Windows.Controls.DataGrid dgListePiece;
        
        internal System.Windows.Controls.ComboBox cbo_typedoc;
        
        internal System.Windows.Controls.TextBox Txt_Client;
        
        internal System.Windows.Controls.Label lbl_Devis_Copy;
        
        internal System.Windows.Controls.Label lbl_Ordre;
        
        internal System.Windows.Controls.TabItem tabItemDemandeur;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationDemandeDevis;
        
        internal System.Windows.Controls.Label lbl_Nom;
        
        internal System.Windows.Controls.TextBox Txt_NomClient;
        
        internal System.Windows.Controls.Label lab_Tournee;
        
        internal System.Windows.Controls.Label lbl_CategorieClient;
        
        internal System.Windows.Controls.Label lbl_Telephone;
        
        internal System.Windows.Controls.TextBox txt_Telephone;
        
        internal System.Windows.Controls.Label lbl_NumLot;
        
        internal System.Windows.Controls.TextBox txt_NumLot;
        
        internal System.Windows.Controls.Label lbl_Piece;
        
        internal System.Windows.Controls.Label lbl_Commune;
        
        internal System.Windows.Controls.TextBox txt_Commune;
        
        internal System.Windows.Controls.Label lbl_Quartier;
        
        internal System.Windows.Controls.TextBox txt_Quartier;
        
        internal System.Windows.Controls.Label lbl_Rue;
        
        internal System.Windows.Controls.TextBox txt_NumRue;
        
        internal System.Windows.Controls.Label lbl_Poteau;
        
        internal System.Windows.Controls.TextBox txtPoteau;
        
        internal System.Windows.Controls.Label lbl_NumPiece;
        
        internal System.Windows.Controls.TextBox txtPropriete;
        
        internal System.Windows.Controls.Label lbl_Adresse;
        
        internal System.Windows.Controls.TextBox txtAdresse;
        
        internal System.Windows.Controls.Label lbl_Proprio;
        
        internal System.Windows.Controls.Label lbl_Calibre;
        
        internal System.Windows.Controls.TextBox txtNumeroPiece;
        
        internal System.Windows.Controls.TextBox Txt_LibelleCommune;
        
        internal System.Windows.Controls.TextBox Txt_LibelleQuartier;
        
        internal System.Windows.Controls.TextBox Txt_LibelleRue;
        
        internal System.Windows.Controls.TextBox Txt_LibelleDiametre;
        
        internal System.Windows.Controls.TextBox Txt_LibelleCategorie;
        
        internal System.Windows.Controls.TextBox Txt_TypePiece;
        
        internal System.Windows.Controls.TextBox Txt_LibelleTournee;
        
        internal System.Windows.Controls.Label lbl_Longitude;
        
        internal System.Windows.Controls.TextBox TxtLongitude;
        
        internal System.Windows.Controls.Label lbl_latitude;
        
        internal System.Windows.Controls.TextBox TxtLatitude;
        
        internal System.Windows.Controls.TabItem tabItemAppareils;
        
        internal System.Windows.Controls.DataGrid dg_compteur;
        
        internal System.Windows.Controls.Button btn_Rejeter;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Devis/UcCalculFactureClient.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.tabControl_Consultation = ((System.Windows.Controls.TabControl)(this.FindName("tabControl_Consultation")));
            this.tabItemDevis = ((System.Windows.Controls.TabItem)(this.FindName("tabItemDevis")));
            this.Gbo_InformationDevis = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationDevis")));
            this.Txt_NumeroDevis = ((System.Windows.Controls.TextBox)(this.FindName("Txt_NumeroDevis")));
            this.lbl_Devis = ((System.Windows.Controls.Label)(this.FindName("lbl_Devis")));
            this.Txt_Ordre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Ordre")));
            this.Txt_CodeSite = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeSite")));
            this.lbl_Site = ((System.Windows.Controls.Label)(this.FindName("lbl_Site")));
            this.Txt_LibelleSite = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleSite")));
            this.Txt_CodeCentre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeCentre")));
            this.lbl_Centre = ((System.Windows.Controls.Label)(this.FindName("lbl_Centre")));
            this.Txt_LibelleCentre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleCentre")));
            this.Txt_LibelleProduit = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleProduit")));
            this.lbl_Produit = ((System.Windows.Controls.Label)(this.FindName("lbl_Produit")));
            this.Txt_CodeProduit = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeProduit")));
            this.Txt_LibelleTypeDevis = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleTypeDevis")));
            this.Txt_EtapeCourante = ((System.Windows.Controls.TextBox)(this.FindName("Txt_EtapeCourante")));
            this.Txt_EtapeSuivante = ((System.Windows.Controls.TextBox)(this.FindName("Txt_EtapeSuivante")));
            this.lbl_TypeDevis = ((System.Windows.Controls.Label)(this.FindName("lbl_TypeDevis")));
            this.lbl_EtapeEnCours = ((System.Windows.Controls.Label)(this.FindName("lbl_EtapeEnCours")));
            this.lbl_EtapeSuivante = ((System.Windows.Controls.Label)(this.FindName("lbl_EtapeSuivante")));
            this.Gbo_PieceJointe = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_PieceJointe")));
            this.dgListePiece = ((System.Windows.Controls.DataGrid)(this.FindName("dgListePiece")));
            this.cbo_typedoc = ((System.Windows.Controls.ComboBox)(this.FindName("cbo_typedoc")));
            this.Txt_Client = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Client")));
            this.lbl_Devis_Copy = ((System.Windows.Controls.Label)(this.FindName("lbl_Devis_Copy")));
            this.lbl_Ordre = ((System.Windows.Controls.Label)(this.FindName("lbl_Ordre")));
            this.tabItemDemandeur = ((System.Windows.Controls.TabItem)(this.FindName("tabItemDemandeur")));
            this.Gbo_InformationDemandeDevis = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationDemandeDevis")));
            this.lbl_Nom = ((System.Windows.Controls.Label)(this.FindName("lbl_Nom")));
            this.Txt_NomClient = ((System.Windows.Controls.TextBox)(this.FindName("Txt_NomClient")));
            this.lab_Tournee = ((System.Windows.Controls.Label)(this.FindName("lab_Tournee")));
            this.lbl_CategorieClient = ((System.Windows.Controls.Label)(this.FindName("lbl_CategorieClient")));
            this.lbl_Telephone = ((System.Windows.Controls.Label)(this.FindName("lbl_Telephone")));
            this.txt_Telephone = ((System.Windows.Controls.TextBox)(this.FindName("txt_Telephone")));
            this.lbl_NumLot = ((System.Windows.Controls.Label)(this.FindName("lbl_NumLot")));
            this.txt_NumLot = ((System.Windows.Controls.TextBox)(this.FindName("txt_NumLot")));
            this.lbl_Piece = ((System.Windows.Controls.Label)(this.FindName("lbl_Piece")));
            this.lbl_Commune = ((System.Windows.Controls.Label)(this.FindName("lbl_Commune")));
            this.txt_Commune = ((System.Windows.Controls.TextBox)(this.FindName("txt_Commune")));
            this.lbl_Quartier = ((System.Windows.Controls.Label)(this.FindName("lbl_Quartier")));
            this.txt_Quartier = ((System.Windows.Controls.TextBox)(this.FindName("txt_Quartier")));
            this.lbl_Rue = ((System.Windows.Controls.Label)(this.FindName("lbl_Rue")));
            this.txt_NumRue = ((System.Windows.Controls.TextBox)(this.FindName("txt_NumRue")));
            this.lbl_Poteau = ((System.Windows.Controls.Label)(this.FindName("lbl_Poteau")));
            this.txtPoteau = ((System.Windows.Controls.TextBox)(this.FindName("txtPoteau")));
            this.lbl_NumPiece = ((System.Windows.Controls.Label)(this.FindName("lbl_NumPiece")));
            this.txtPropriete = ((System.Windows.Controls.TextBox)(this.FindName("txtPropriete")));
            this.lbl_Adresse = ((System.Windows.Controls.Label)(this.FindName("lbl_Adresse")));
            this.txtAdresse = ((System.Windows.Controls.TextBox)(this.FindName("txtAdresse")));
            this.lbl_Proprio = ((System.Windows.Controls.Label)(this.FindName("lbl_Proprio")));
            this.lbl_Calibre = ((System.Windows.Controls.Label)(this.FindName("lbl_Calibre")));
            this.txtNumeroPiece = ((System.Windows.Controls.TextBox)(this.FindName("txtNumeroPiece")));
            this.Txt_LibelleCommune = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleCommune")));
            this.Txt_LibelleQuartier = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleQuartier")));
            this.Txt_LibelleRue = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleRue")));
            this.Txt_LibelleDiametre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleDiametre")));
            this.Txt_LibelleCategorie = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleCategorie")));
            this.Txt_TypePiece = ((System.Windows.Controls.TextBox)(this.FindName("Txt_TypePiece")));
            this.Txt_LibelleTournee = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleTournee")));
            this.lbl_Longitude = ((System.Windows.Controls.Label)(this.FindName("lbl_Longitude")));
            this.TxtLongitude = ((System.Windows.Controls.TextBox)(this.FindName("TxtLongitude")));
            this.lbl_latitude = ((System.Windows.Controls.Label)(this.FindName("lbl_latitude")));
            this.TxtLatitude = ((System.Windows.Controls.TextBox)(this.FindName("TxtLatitude")));
            this.tabItemAppareils = ((System.Windows.Controls.TabItem)(this.FindName("tabItemAppareils")));
            this.dg_compteur = ((System.Windows.Controls.DataGrid)(this.FindName("dg_compteur")));
            this.btn_Rejeter = ((System.Windows.Controls.Button)(this.FindName("btn_Rejeter")));
        }
    }
}


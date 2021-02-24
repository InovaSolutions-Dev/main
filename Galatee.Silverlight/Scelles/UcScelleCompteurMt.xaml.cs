﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Galatee.Silverlight.Library;
using Galatee.Silverlight.ServiceScelles;
using Galatee.Silverlight.Resources.Scelles;
using Galatee.Silverlight.Tarification.Helper;

namespace Galatee.Silverlight.Scelles
{
    public partial class UcScelleCompteurMt : ChildWindow
    {
        public CsRechercheCompteur lecompteur;
        List<Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur> ListdesModelesfonctMarq = new List<Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur>();
        List<CsRemiseScelleByAg> ListdesScelles = new List<CsRemiseScelleByAg>();
        private CsCompteurBta ObjetSelectionnee = null;
        static int ID_MArque, nbr_capot, nb_cache, ID_Diametre;
        private List<ServiceAccueil.CsCentre> _listeDesCentreExistant = null;

        private Object ModeExecution = null;
        private DataGrid dataGrid = null;
        List<CsCompteurBta> listForInsertOrUpdate = new List<CsCompteurBta>();
        public UcScelleCompteurMt()
        {
            InitializeComponent();
            RemplirListeCmbDesEtatCompteursExistant();
            RemplirListeCmbDesModelesMarqueExistant();
            ChargerProduit();
            ModeExecution = SessionObject.ExecMode.Creation;
            this.txt_NumCpteur.MaxLength = 20;
            this.txt_ANNEEFAB.MaxLength = 4;
            this.txt_Cadran.MaxLength = 1;
            this.txt_Cadran.Text = "6";
            SelectAllCompteurNonAffecte();
            //OKButton.IsEnabled = true;
        }
        public UcScelleCompteurMt(CsCompteurBta pObject, SessionObject.ExecMode pExecMode, DataGrid pGrid)
        {
            try
            {
                InitializeComponent();
                Translate();
                var CompteurBt = new CsCompteurBta();
                if (pObject != null)
                    ObjetSelectionnee = Utility.ParseObject(CompteurBt, pObject as CsCompteurBta);

                this.txt_NumCpteur.MaxLength = 20;
                this.txt_ANNEEFAB.MaxLength = 4;
                this.txt_Cadran .MaxLength = 1;
                this.txt_Cadran.Text  = "6";
                ModeExecution = pExecMode;
                dataGrid = pGrid;
                // dtgrdlReceptionScelle.ItemsSource = donnesDatagrid;
                RemplirListeCmbDesEtatCompteursExistant();
                RemplirListeCmbDesModelesMarqueExistant();
                ChargerProduit();
                //if (dataGrid != null) 
                //    donnesDatagrid = dataGrid.ItemsSource as ObservableCollection<CsLotMagasinGeneral>;
                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Modification || (SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Consultation)
                {
                    if (ObjetSelectionnee != null)
                    {
                        List<CsRefEtatCompteur> lstetat = (List<CsRefEtatCompteur>)this.Cbo_Etat_cmpt.ItemsSource;
                        if (lstetat != null)
                            Cbo_Etat_cmpt.SelectedItem = lstetat.FirstOrDefault(t => t.EtatCompteur_ID == ObjetSelectionnee.EtatCompteur_ID);

                        List<Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur> lstMaqmMdt = ListdesModelesfonctMarq;
                        if (lstMaqmMdt != null)
                            Cbo_Marque.SelectedItem =ObjetSelectionnee.LIBELLEMARQUE ;

                        txt_ANNEEFAB.Text = ObjetSelectionnee.ANNEEFAB;
                        txt_NumCpteur.Text = ObjetSelectionnee.Numero_Compteur;
                    }
                }
                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Consultation)
                {
                    AllInOne.ActivateControlsFromXaml(LayoutRoot, false);
                }
                //VerifierSaisie();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, Languages.Commune);
            }
        }

        #region EventHandling

        public delegate void MethodeEventHandler(object sender, CustumEventArgs e);
        public event MethodeEventHandler CallBack;
        CustumEventArgs MyEventArg = new CustumEventArgs();

        protected virtual void OnEvent(CustumEventArgs e)
        {
            if (CallBack != null)
                CallBack(this, e);
        }

        #endregion
        private void Translate()
        {
            try
            {
                Title = Languages.Scelles;
                //btnOk.Content = Languages.OK;
                //Btn_Reinitialiser.Content = Languages.Annuler;
                //GboCodeDepart.Header = Languages.InformationsCodePoste;
                //lab_Code.Content = Languages.Code;
                //lab_Libelle.Content = Languages.Libelle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void SelectAllCompteurNonAffecte()
        {
            try
            {
                IScelleServiceClient client = new IScelleServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Scelles"));
                client.SelectAllCompteurNonAffecteCompleted += (ssender, args) =>
                {
                    if (args.Cancelled || args.Error != null)
                    {
                        string error = args.Error.Message;
                        Message.ShowError(error, Languages.Quartier);
                        return;
                    }
                    if (args.Result == null)
                    {
                        Message.ShowError(Languages.msgErreurChargementDonnees, Languages.Scelles);
                        return;
                    }
                    else
                    {
                        this.dtg_CompteurSaisie.ItemsSource = null;
                        this.dtg_CompteurSaisie.ItemsSource = args.Result;
                    }
                };
                client.SelectAllCompteurNonAffecteAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        private void RemplirListeCmbDesModelesMarqueExistant()
        {
            try
            {
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient client = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                client.RetourneToutMarqueCompleted += (ssender, args) =>
                {
                    if (args.Cancelled || args.Error != null)
                    {
                        string error = args.Error.Message;
                        Message.ShowError(error, Languages.Quartier);
                        return;
                    }
                    if (args.Result == null)
                    {
                        Message.ShowError(Languages.msgErreurChargementDonnees, Languages.Scelles);
                        return;
                    }
                    else
                    {
                        ListdesModelesfonctMarq = args.Result;
                        this.Cbo_Marque.ItemsSource = ListdesModelesfonctMarq;
                        this.Cbo_Marque.DisplayMemberPath = "LIBELLE";
                        this.Cbo_Marque.SelectedValuePath = "PK_ID";
                        this.Cbo_Marque.SelectedValue = string.Empty;

                    }
                };
                client.RetourneToutMarqueAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        List<CsRefEtatCompteur> lstEtatCompteur = new List<CsRefEtatCompteur>();
        private void RemplirListeCmbDesEtatCompteursExistant()
        {
            try
            {
                IScelleServiceClient client = new IScelleServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Scelles"));
                client.RetourneEtatCompteurCompleted += (ssender, args) =>
                {
                    if (args.Cancelled || args.Error != null)
                    {
                        string error = args.Error.Message;
                        Message.ShowError(error, Languages.Quartier);
                        return;
                    }
                    if (args.Result == null)
                    {
                        Message.ShowError(Languages.msgErreurChargementDonnees, Languages.Scelles);
                        return;
                    }
                    else
                    {
                        lstEtatCompteur = args.Result;
                        this.Cbo_Etat_cmpt.ItemsSource = lstEtatCompteur;
                        this.Cbo_Etat_cmpt.DisplayMemberPath = "Libelle_ETAT";
                        this.Cbo_Etat_cmpt.SelectedValuePath = "EtatCompteur_ID";

                        if (ObjetSelectionnee != null)
                        {
                            foreach (CsRefEtatCompteur marqModl in Cbo_Etat_cmpt.ItemsSource)
                            {
                                if (marqModl.EtatCompteur_ID != null)
                                {
                                    Cbo_Etat_cmpt.SelectedItem = marqModl;
                                    break;
                                }
                            }
                        }
                    }
                };
                client.RetourneEtatCompteurAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void ChargerProduit()
        {
            try
            {
                if (SessionObject.ListeDesProduit != null && SessionObject.ListeDesProduit.Count != 0)
                {
                    return;
                }
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service1 = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service1.ListeDesProduitCompleted += (sr, res) =>
                {
                    if (res != null && res.Cancelled)
                        return;
                    SessionObject.ListeDesProduit = res.Result;
                };
                service1.ListeDesProduitAsync();
                service1.CloseAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private List<CsCompteurBta> GetInformationsFromScreen()
        {
            var listObjetForInsertOrUpdate = new List<CsCompteurBta>();
            try
            {

                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Creation)
                {
                        var tCompteur = new CsCompteurBta();
                        tCompteur.Numero_Compteur = txt_NumCpteur.Text;
                        tCompteur.EtatCompteur_ID = ((CsRefEtatCompteur)Cbo_Etat_cmpt.SelectedItem).EtatCompteur_ID;
                        tCompteur.ANNEEFAB = txt_ANNEEFAB.Text;
                        tCompteur.FONCTIONNEMENT = "1";
                        tCompteur.CADRAN = Convert.ToByte(this.txt_Cadran .Text );
                        tCompteur.FK_IDCALIBRECOMPTEUR = null;
                        tCompteur.FK_IDTYPECOMPTEUR = 1;
                        tCompteur.FK_IDMARQUECOMPTEUR  = ((Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur)Cbo_Marque.SelectedItem).PK_ID ;
                        tCompteur.MARQUE = ((Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur)Cbo_Marque.SelectedItem).CODE;
                        tCompteur.DATECREATION = DateTime.Now;
                        tCompteur.USERCREATION = UserConnecte.matricule;
                        tCompteur.ETAT = "Non_Affecté";
                        tCompteur.StatutCompteur="Non_Affecté";
                        tCompteur.CODEPRODUIT = SessionObject.ListeDesProduit.FirstOrDefault(t=>t.CODE == SessionObject.Enumere.ElectriciteMT).CODE ;
                        tCompteur.FK_IDPRODUIT = SessionObject.ListeDesProduit.FirstOrDefault(t => t.CODE == SessionObject.Enumere.ElectriciteMT).PK_ID ;
                        tCompteur.NUMERO = txt_NumCpteur.Text;
                        if (ObjetSelectionnee != null)
                        {
                            if (ObjetSelectionnee.CapotMoteur_ID_Scelle1 != null)
                                tCompteur.CapotMoteur_ID_Scelle1 = ObjetSelectionnee.CapotMoteur_ID_Scelle1;
                            if (ObjetSelectionnee.CapotMoteur_ID_Scelle2 != null)
                                tCompteur.CapotMoteur_ID_Scelle2 = ObjetSelectionnee.CapotMoteur_ID_Scelle2;
                            if (ObjetSelectionnee.CapotMoteur_ID_Scelle3 != null)
                                tCompteur.CapotMoteur_ID_Scelle3 = ObjetSelectionnee.CapotMoteur_ID_Scelle3;
                        }
                        listObjetForInsertOrUpdate.Add(tCompteur);
                    
                }

                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Modification)
                {
                        ObjetSelectionnee.Numero_Compteur = txt_NumCpteur.Text;
                        ObjetSelectionnee.EtatCompteur_ID = ((CsRefEtatCompteur)Cbo_Etat_cmpt.SelectedItem).EtatCompteur_ID;
                        ObjetSelectionnee.ANNEEFAB = txt_ANNEEFAB.Text;
                        ObjetSelectionnee.FONCTIONNEMENT = "1";
                        ObjetSelectionnee.CADRAN = Convert.ToByte(this.txt_Cadran.Text );
                        ObjetSelectionnee.FK_IDTYPECOMPTEUR = null;
                        //ObjetSelectionnee.FK_IDCALIBRECOMPTEUR  = ((ServiceAccueil.CsCalibreCompteur)Cbo_Diametre.SelectedItem).PK_ID;
                        ObjetSelectionnee.MARQUE = ((Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur)Cbo_Marque.SelectedItem).CODE;
                        ObjetSelectionnee.FK_IDMARQUECOMPTEUR = ((Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur)Cbo_Marque.SelectedItem).PK_ID ;
                        ObjetSelectionnee.DATEMODIFICATION = DateTime.Now;
                        ObjetSelectionnee.USERMODIFICATION = UserConnecte.matricule;
                        listObjetForInsertOrUpdate.Add(ObjetSelectionnee);
                    
                }
                return listObjetForInsertOrUpdate;
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, Languages.EtatDuCompteur);
                return null;
            }
        }
        private void RazEcran()
        {
            this.Cbo_Marque.SelectedItem = null;
            this.Cbo_Etat_cmpt.SelectedItem = null;
            this.txt_ANNEEFAB.Text = string.Empty;
            this.txt_NumCpteur .Text = string.Empty;
            this.txt_Cadran .Text = string.Empty;
            this.txt_Cadran .Text = string.Empty;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var messageBox = new MessageBoxControl.MessageBoxChildWindow(Languages.Commune, Languages.QuestionEnregistrerDonnees, MessageBoxControl.MessageBoxButtons.YesNo, MessageBoxControl.MessageBoxIcon.Question);
                messageBox.OnMessageBoxClosed += (_, result) =>
                {
                    if (messageBox.Result == MessageBoxResult.OK)
                    {

                        listForInsertOrUpdate = GetInformationsFromScreen();
                        var service = new IScelleServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Scelles"));

                        if (listForInsertOrUpdate != null && listForInsertOrUpdate.Count > 0)
                        {
                            
                            if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Creation)
                            {
                                service.VerifieCompteurExisteCompleted += (snder, insertR) =>
                                {
                                    if (insertR.Cancelled ||
                                        insertR.Error != null)
                                    {
                                        Message.ShowError(insertR.Error.Message, Languages.EtatDuCompteur);
                                        return;
                                    }
                                    if (insertR.Result)
                                    {
                                        Message.ShowError(Languages.ErreurInsertionDonnees, Languages.EtatDuCompteur);
                                        return;
                                    }
                                    else
                                    {
                                        service.InsertCompteurCompleted += (sndere, insertRe) =>
                                        {
                                            if (insertRe.Cancelled ||
                                                insertRe.Error != null)
                                            {
                                                Message.ShowError(insertR.Error.Message, Languages.EtatDuCompteur);
                                                return;
                                            }
                                            if (!string.IsNullOrEmpty(insertRe.Result))
                                            {
                                                Message.ShowError(Languages.ErreurInsertionDonnees, Languages.EtatDuCompteur);
                                                return;
                                            }
                                            else
                                            {
                                                Message.ShowInformation("Compteur ajouté avec succès", Languages.EtatDuCompteur);
                                                RazEcran();
                                                SelectAllCompteurNonAffecte();
                                                OKButton.IsEnabled = true;
                                                btn_Annuler.IsEnabled = true;
                                                CancelButton.IsEnabled = true;
                                                btn_Modifier.IsEnabled = true;

                                                return;
                                            }
                                        };
                                        service.InsertCompteurAsync(listForInsertOrUpdate);
                                    }
                                };
                                service.VerifieCompteurExisteAsync(listForInsertOrUpdate.First());
                               }
                           
                            if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Modification)
                            {
                                service.UpdateCompteurCompleted += (snder, UpdateR) =>
                                {
                                    if (UpdateR.Cancelled ||
                                        UpdateR.Error != null)
                                    {
                                        Message.ShowError(UpdateR.Error.Message, Languages.EtatDuCompteur);
                                        return;
                                    }
                                    if (UpdateR.Result==0)
                                    {
                                        Message.ShowError(Languages.ErreurMiseAJourDonnees, Languages.EtatDuCompteur);
                                        return;
                                    }
                                    else
                                    {
                                        Message.ShowInformation ("Compteur modifié avec succès", Languages.EtatDuCompteur);
                                        RazEcran();
                                        SelectAllCompteurNonAffecte();
                                        return;
                                    }
                                    //OnEvent(null);
                                    //DialogResult = true;
                                };
                                service.UpdateCompteurAsync(listForInsertOrUpdate);
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                };
                messageBox.Show();
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, Languages.Commune);
            }
        }
        private void DeleteCompteur(CsCompteurBta listForCompteur)
        {
            try
            {

                var service = new IScelleServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Scelles"));

                if (listForCompteur != null )
                {
                    service.DeleteCompteurCompleted += (snder, UpdateR) =>
                    {
                        if (UpdateR.Cancelled ||
                            UpdateR.Error != null)
                        {
                            Message.ShowError(UpdateR.Error.Message, Languages.EtatDuCompteur);
                            return;
                        }
                        if (UpdateR.Result == false)
                        {
                            Message.ShowError(Languages.ErreurMiseAJourDonnees, Languages.EtatDuCompteur);
                            return;
                        }
                        else
                        {
                            //Message.ShowInformation("Compteur modifié avec succès", Languages.EtatDuCompteur);
                            //RazEcran();
                            //SelectAllCompteurNonAffecte();
                            //return;
                        }
                        //OnEvent(null);
                        //DialogResult = true;
                    };
                    service.DeleteCompteurAsync(listForCompteur);

                }
            }

            catch (Exception ex)
            {
                Message.Show(ex.Message, Languages.Commune);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Shared.ClasseMEthodeGenerique.FermetureEcran(this);
        }

        private void Cbo_Marque_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (Cbo_Marque.SelectedItem == null)
                    return;
                if (Cbo_Marque.SelectedValue != null  )
                    ID_MArque = ((Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur)Cbo_Marque.SelectedItem).PK_ID ;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btn_Modifier_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.dtg_CompteurSaisie.SelectedItem != null)
            {
                ModeExecution = SessionObject.ExecMode.Creation ;
                ObjetSelectionnee = (CsCompteurBta)this.dtg_CompteurSaisie.SelectedItem;
                this.txt_ANNEEFAB.Text = ObjetSelectionnee.ANNEEFAB;
                this.txt_NumCpteur.Text = ObjetSelectionnee.Numero_Compteur;
                this.txt_Cadran.Text = ObjetSelectionnee.CADRAN.ToString();
                this.Cbo_Etat_cmpt.SelectedItem = lstEtatCompteur.FirstOrDefault(t => t.EtatCompteur_ID == ObjetSelectionnee.EtatCompteur_ID); ;
                this.Cbo_Marque.SelectedItem = ListdesModelesfonctMarq.FirstOrDefault(t => t.PK_ID == ObjetSelectionnee.FK_IDMARQUECOMPTEUR);
                OKButton.IsEnabled = true;
                btn_Annuler.IsEnabled = false;
                CancelButton.IsEnabled = false;
                btn_Modifier.IsEnabled = false;
                DeleteCompteur(ObjetSelectionnee);

            }
        }
        private void btn_Annuler_Click_1(object sender, RoutedEventArgs e)
        {
            RazEcran();
            ModeExecution = SessionObject.ExecMode.Creation ;
        }
        //private void btn_Modifier_Click_1(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        if (this.dtg_CompteurSaisie.SelectedItem != null)
        //        {
        //            ObjetSelectionnee = (CsCompteurBta)this.dtg_CompteurSaisie.SelectedItem;
        //            //if (ObjetSelectionnee.EtatCompteur_ID != 0)
        //            //{
        //            //    Message.ShowInformation("Ce Etat Compteur ne peut ètre modifier ", "info");
        //            //    ObjetSelectionnee = null;
        //            //    return;
        //            //}
        //            ModeExecution = SessionObject.ExecMode.Modification;
        //            if (ListdesModelesfonctMarq.Count != 0)
        //            {
        //                if (ObjetSelectionnee != null)
        //                {
        //                    this.Cbo_Marque.ItemsSource = ListdesModelesfonctMarq;
        //                    this.Cbo_Marque.DisplayMemberPath = "LIBELLE";
        //                    this.Cbo_Marque.SelectedValuePath = "PK_ID";

        //                    foreach (Galatee.Silverlight.ServiceAccueil.CsMarqueCompteur OgSll in Cbo_Marque.ItemsSource)
        //                    {
        //                        if (OgSll.PK_ID == ObjetSelectionnee.FK_IDMARQUECOMPTEUR)
        //                        {
        //                            Cbo_Marque.SelectedItem = OgSll;
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
                   
        //            if (lstEtatCompteur.Count != 0)
        //            {
        //                if (ObjetSelectionnee != null)
        //                {
        //                    this.Cbo_Etat_cmpt.ItemsSource = lstEtatCompteur;
        //                    this.Cbo_Etat_cmpt.DisplayMemberPath = "Libelle_ETAT";
        //                    this.Cbo_Etat_cmpt.SelectedValuePath = "EtatCompteur_ID";
        //                    foreach (CsRefEtatCompteur OgSll in Cbo_Etat_cmpt.ItemsSource)
        //                    {
        //                        if (OgSll.EtatCompteur_ID == ObjetSelectionnee.EtatCompteur_ID)
        //                        {
        //                            Cbo_Etat_cmpt.SelectedItem = OgSll;
        //                            break;
        //                        }
        //                    }
        //                }

        //            }
        //            //if (SessionObject.LstDesActivitee.Count != 0)
        //            //{
        //            //    if (ObjetSelectionnee != null)
        //            //    {
        //            //        this.Cbo_Activite.ItemsSource = SessionObject.LstDesActivitee;
        //            //        this.Cbo_Activite.DisplayMemberPath = "Activite_Libelle";
        //            //        this.Cbo_Activite.SelectedValuePath = "Activite_ID";
        //            //        foreach (CsActivite Activite in Cbo_Activite.ItemsSource)
        //            //        {
        //            //            if (Activite.Activite_ID == ObjetSelectionnee.Activite_ID)
        //            //            {
        //            //                Cbo_Activite.SelectedItem = Activite;
        //            //                break;
        //            //            }
        //            //        }
        //            //    }
        //            //}
        //            List<CsLotMagasinGeneral> lstLotScelle = new List<CsLotMagasinGeneral>();
        //            //lstLotScelle.Add(new CsLotMagasinGeneral
        //            //{
        //            //    Numero_depart = ObjetSelectionnee.Numero_depart,
        //            //    Numero_fin = ObjetSelectionnee.Numero_fin

        //            //});
        //            //txt_NumeroDepart.Text = ObjetSelectionnee.Numero_depart;
        //            //txt_NumeroFin.Text = ObjetSelectionnee.Numero_fin;

        //            //dtgrdlReceptionScelle.ItemsSource = lstLotScelle;
        //            //btn_ajout.IsEnabled = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Message.ShowError("Erreur au chargement des données", "Erreur");
        //    }
        //}

        private void dtg_CompteurSaisie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}


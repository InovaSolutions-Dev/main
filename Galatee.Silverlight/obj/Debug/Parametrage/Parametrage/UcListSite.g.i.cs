﻿#pragma checksum "D:\TFS_SOURCE_EDM\iWEBS_EDMSA\Galatee.Silverlight\Parametrage\Parametrage\UcListSite.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "23F28E2A57203ACAE1A6B330E6C4B082"
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
    
    
    public partial class UcListSite : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ProgressBar progressBar1;
        
        internal System.Windows.Controls.Button btnPrint;
        
        internal System.Windows.Controls.DataGrid dtgrdParametre;
        
        internal System.Windows.Controls.Button btnDelete;
        
        internal SilverlightContrib.Controls.GroupBox GroupBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/Parametrage/UcListSite.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.progressBar1 = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar1")));
            this.btnPrint = ((System.Windows.Controls.Button)(this.FindName("btnPrint")));
            this.dtgrdParametre = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdParametre")));
            this.btnDelete = ((System.Windows.Controls.Button)(this.FindName("btnDelete")));
            this.GroupBox = ((SilverlightContrib.Controls.GroupBox)(this.FindName("GroupBox")));
        }
    }
}


﻿#pragma checksum "E:\DOCUMENTATION\EDMSA\LIVRAISON 2021 02 15 - SPRINT 2\SPRINT 2\iWEBS_EDMSA\Galatee.Silverlight\Workflow\UcListeEtapeOption.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9C36A0D9D47906AD2B87F4B163D83FF"
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


namespace Galatee.Silverlight.Workflow {
    
    
    public partial class UcListeEtapeOption : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DataGrid dtgEtape;
        
        internal System.Windows.Controls.Label lbl_Circuitname;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Workflow/UcListeEtapeOption.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.dtgEtape = ((System.Windows.Controls.DataGrid)(this.FindName("dtgEtape")));
            this.lbl_Circuitname = ((System.Windows.Controls.Label)(this.FindName("lbl_Circuitname")));
        }
    }
}

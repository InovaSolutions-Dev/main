//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galatee.Entity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GRC_VEHICULE
    {
        public GRC_VEHICULE()
        {
            this.TRAVAUXDEVIS = new HashSet<TRAVAUXDEVIS>();
        }
    
        public int ID { get; set; }
        public string LIBELLE { get; set; }
        public string IMMATRICULATION { get; set; }
        public string MARQUE { get; set; }
        public Nullable<int> ID_TYPE_VEHICULE { get; set; }
        public bool EST_SUPRIME { get; set; }
        public string ID_ENTITE { get; set; }
        public Nullable<System.DateTime> DATE_MISE_EN_SERVICE { get; set; }
        public Nullable<System.DateTime> DATE_FIN_UTILISATION { get; set; }
        public int ID_STATUT { get; set; }
        public string EXPLOITATION { get; set; }
        public string IMMOBILISATION { get; set; }
        public string NUMERORADIO { get; set; }
        public string CREER_PAR { get; set; }
        public System.DateTime DATE_CREATION { get; set; }
        public string DERNIER_UTILISATEUR { get; set; }
        public System.DateTime DATE_MODIFICATION { get; set; }
    
        public virtual ICollection<TRAVAUXDEVIS> TRAVAUXDEVIS { get; set; }
        public virtual GRC_TYPE_VEHICULE GRC_TYPE_VEHICULE { get; set; }
    }
}

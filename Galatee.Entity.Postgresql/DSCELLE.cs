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
    
    public partial class DSCELLE
    {
        public string NUMDEM { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDACTIVITE { get; set; }
        public int FK_IDCOULEURSCELLE { get; set; }
        public int FK_IDDEMANDE { get; set; }
        public Nullable<int> FK_IDAGENT { get; set; }
        public int NOMBRE_DEM { get; set; }
        public Nullable<int> NOMBRE_REC { get; set; }
        public int PK_ID { get; set; }
        public Nullable<int> FK_IDCENTREFOURNISSEUR { get; set; }
    
        public virtual ADMUTILISATEUR ADMUTILISATEUR { get; set; }
        public virtual CENTRE CENTRE { get; set; }
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual RefActivite RefActivite { get; set; }
        public virtual RefCouleurlot RefCouleurlot { get; set; }
        public virtual DEMANDE DEMANDE { get; set; }
    }
}

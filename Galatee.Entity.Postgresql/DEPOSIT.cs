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
    
    public partial class DEPOSIT
    {
        public int PK_ID { get; set; }
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string ORDRE { get; set; }
        public Nullable<decimal> MONTANTDEPOSIT { get; set; }
        public string RECEIPT { get; set; }
        public System.DateTime DATEENC { get; set; }
        public string NUMDEM { get; set; }
        public string NOM { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public string IDENTITE { get; set; }
        public string TOPANNUL { get; set; }
        public Nullable<decimal> MONTANTTVA { get; set; }
        public string BANQUE { get; set; }
        public string COMPTE { get; set; }
        public Nullable<System.Guid> IDLETTER { get; set; }
        public Nullable<bool> ISCREATED { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int FK_IDCENTRE { get; set; }
    
        public virtual CENTRE CENTRE1 { get; set; }
    }
}

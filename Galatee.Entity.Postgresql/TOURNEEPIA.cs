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
    
    public partial class TOURNEEPIA
    {
        public int PK_ID { get; set; }
        public int FK_IDADMUTILSATEUR { get; set; }
        public int FK_IDTOURNEE { get; set; }
        public System.DateTime DATEDEBUT { get; set; }
        public Nullable<System.DateTime> DATEFIN { get; set; }
        public Nullable<decimal> SOLDETOURNEE { get; set; }
    
        public virtual ADMUTILISATEUR ADMUTILISATEUR { get; set; }
        public virtual TOURNEE TOURNEE { get; set; }
    }
}
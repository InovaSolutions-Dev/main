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
    
    public partial class VW_JOURNAL_DEMANDE
    {
        public int IDETAPE { get; set; }
        public string NOM { get; set; }
        public Nullable<int> FK_IDETAPEACTUELLE { get; set; }
        public System.Guid IDCIRCUIT { get; set; }
        public string CODE { get; set; }
        public Nullable<System.DateTime> DATECREATION { get; set; }
        public Nullable<int> ETAPEPRECEDENTE { get; set; }
        public string MATRICULEUSERCREATION { get; set; }
        public System.Guid FK_IDGROUPEVALIDATIOIN { get; set; }
        public System.Guid FK_IDWORKFLOW { get; set; }
        public System.Guid FK_IDOPERATION { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int ORDRE { get; set; }
        public int FK_IDETAPE { get; set; }
        public Nullable<int> DUREE { get; set; }
        public Nullable<int> ALERTE { get; set; }
        public string CONTROLEETAPE { get; set; }
        public Nullable<int> FK_IDMENU { get; set; }
        public Nullable<int> FK_IDSTATUS { get; set; }
        public Nullable<System.DateTime> DATEDERNIEREMODIFICATION { get; set; }
        public System.Guid RAFFECTATIONETAPE { get; set; }
        public Nullable<bool> ALLCENTRE { get; set; }
        public Nullable<int> IDCENTRE { get; set; }
        public string CODECENTRE { get; set; }
        public string LIBELLECENTRE { get; set; }
        public string CODESITE { get; set; }
        public string LIBELLESITE { get; set; }
        public int IDSITE { get; set; }
        public Nullable<int> FK_IDTABLETRAVAIL { get; set; }
        public string FK_IDLIGNETABLETRAVAIL { get; set; }
        public string CODE_DEMANDE_TABLETRAVAIL { get; set; }
        public Nullable<bool> ISMODIFICATION { get; set; }
        public Nullable<System.Guid> FK_IDETAPECIRCUIT { get; set; }
        public Nullable<System.Guid> FK_IDDEMANDE { get; set; }
    }
}

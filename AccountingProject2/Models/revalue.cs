//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingProject2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class revalue
    {
        public string doc_type { get; set; }
        public string doc_no { get; set; }
        public System.DateTime doc_date { get; set; }
        public string gain_accno { get; set; }
        public string loss_accno { get; set; }
        public string refno { get; set; }
        public string desp { get; set; }
        public string desp2 { get; set; }
        public decimal amount { get; set; }
        public string batchno { get; set; }
        public string lkdoc_type { get; set; }
        public string lkdoc_no { get; set; }
        public System.DateTime lkdoc_date { get; set; }
        public string lkrefno { get; set; }
        public string lkbatchno { get; set; }
        public string createdby { get; set; }
        public string updatedby { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> lastupdate { get; set; }
    }
}
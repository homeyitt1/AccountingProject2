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
    
    public partial class stock
    {
        public string prodcode { get; set; }
        public string doc_type { get; set; }
        public string doc_no { get; set; }
        public int dkey { get; set; }
        public int line_no { get; set; }
        public System.DateTime doc_date { get; set; }
        public string doc_desp { get; set; }
        public string custcode { get; set; }
        public string suppcode { get; set; }
        public string refno { get; set; }
        public string refno2 { get; set; }
        public decimal qty { get; set; }
        public decimal cost { get; set; }
        public decimal price { get; set; }
        public decimal local_amount { get; set; }
        public decimal utd_cost { get; set; }
        public string location { get; set; }
        public string batchcode { get; set; }
        public string projcode { get; set; }
        public string deptcode { get; set; }
        public string pkdoc_type { get; set; }
        public string pkdoc_no { get; set; }
        public int pkdkey { get; set; }
        public int bfseq { get; set; }
    }
}

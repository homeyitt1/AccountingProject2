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
    
    public partial class gl_arc
    {
        public string accno { get; set; }
        public string doc_type { get; set; }
        public System.DateTime doc_date { get; set; }
        public string refno { get; set; }
        public string desp { get; set; }
        public decimal amount { get; set; }
        public string projcode { get; set; }
        public string deptcode { get; set; }
    }
}
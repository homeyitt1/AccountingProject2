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
    
    public partial class cashier
    {
        public string cashier_id { get; set; }
        public string cashier_name { get; set; }
        public string cashier_pwd { get; set; }
        public bool allow_price { get; set; }
        public bool allow_disc { get; set; }
        public bool allow_delete { get; set; }
        public bool inactive { get; set; }
    }
}

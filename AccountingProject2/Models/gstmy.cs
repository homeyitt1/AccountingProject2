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
    
    public partial class gstmy
    {
        public System.DateTime taxdate { get; set; }
        public bool amended { get; set; }
        public string taxno { get; set; }
        public string companyname { get; set; }
        public System.DateTime date_start { get; set; }
        public System.DateTime date_end { get; set; }
        public System.DateTime due_date { get; set; }
        public decimal o_taxable { get; set; }
        public decimal o_tax { get; set; }
        public decimal i_taxable { get; set; }
        public decimal i_tax { get; set; }
        public decimal tax_pay { get; set; }
        public decimal tax_claim { get; set; }
        public string refundcf { get; set; }
        public decimal zr_tax_l { get; set; }
        public decimal zr_tax_e { get; set; }
        public decimal es_tax { get; set; }
        public decimal rs_tax { get; set; }
        public decimal is_taxable { get; set; }
        public decimal is_tax { get; set; }
        public decimal tx_taxable_cga { get; set; }
        public decimal ap_taxable { get; set; }
        public decimal as_taxable { get; set; }
        public string mi_code1 { get; set; }
        public string mi_code2 { get; set; }
        public string mi_code3 { get; set; }
        public string mi_code4 { get; set; }
        public string mi_code5 { get; set; }
        public decimal mi_tax1 { get; set; }
        public decimal mi_tax2 { get; set; }
        public decimal mi_tax3 { get; set; }
        public decimal mi_tax4 { get; set; }
        public decimal mi_tax5 { get; set; }
        public decimal mi_tax6 { get; set; }
        public decimal mi_pct1 { get; set; }
        public decimal mi_pct2 { get; set; }
        public decimal mi_pct3 { get; set; }
        public decimal mi_pct4 { get; set; }
        public decimal mi_pct5 { get; set; }
        public decimal mi_pct6 { get; set; }
        public string dc_name { get; set; }
        public string dc_newic { get; set; }
        public string dc_oldic { get; set; }
        public string dc_passport { get; set; }
        public string dc_nation { get; set; }
        public System.DateTime dc_date { get; set; }
        public string createdby { get; set; }
        public string updatedby { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> lastupdate { get; set; }
    }
}

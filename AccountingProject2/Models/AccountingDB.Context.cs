﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class recontestEntities : DbContext
    {
        public recontestEntities()
            : base("name=recontestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<accmgr> accmgrs { get; set; }
        public virtual DbSet<accmgrcom> accmgrcoms { get; set; }
        public virtual DbSet<ap> aps { get; set; }
        public virtual DbSet<ar> ars { get; set; }
        public virtual DbSet<billremark> billremarks { get; set; }
        public virtual DbSet<buyer> buyers { get; set; }
        public virtual DbSet<cashier> cashiers { get; set; }
        public virtual DbSet<cashnote> cashnotes { get; set; }
        public virtual DbSet<cb> cbs { get; set; }
        public virtual DbSet<counter> counters { get; set; }
        public virtual DbSet<countert> counterts { get; set; }
        public virtual DbSet<countertsdet> countertsdets { get; set; }
        public virtual DbSet<currency> currencies { get; set; }
        public virtual DbSet<currencyrate> currencyrates { get; set; }
        public virtual DbSet<custaddr> custaddrs { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<defdocno> defdocnoes { get; set; }
        public virtual DbSet<defgl> defgls { get; set; }
        public virtual DbSet<defoption> defoptions { get; set; }
        public virtual DbSet<defprofile> defprofiles { get; set; }
        public virtual DbSet<defrefno> defrefnoes { get; set; }
        public virtual DbSet<defxl> defxls { get; set; }
        public virtual DbSet<deptment> deptments { get; set; }
        public virtual DbSet<extdoc> extdocs { get; set; }
        public virtual DbSet<facategory> facategories { get; set; }
        public virtual DbSet<facomment> facomments { get; set; }
        public virtual DbSet<fasset> fassets { get; set; }
        public virtual DbSet<fatran> fatrans { get; set; }
        public virtual DbSet<favendor> favendors { get; set; }
        public virtual DbSet<gl_arc> gl_arc { get; set; }
        public virtual DbSet<glbatch> glbatches { get; set; }
        public virtual DbSet<glbatchgrp> glbatchgrps { get; set; }
        public virtual DbSet<glbudget> glbudgets { get; set; }
        public virtual DbSet<glcl> glcls { get; set; }
        public virtual DbSet<glconso> glconsoes { get; set; }
        public virtual DbSet<gldata> gldatas { get; set; }
        public virtual DbSet<gldesp> gldesps { get; set; }
        public virtual DbSet<glfa> glfas { get; set; }
        public virtual DbSet<glgrp> glgrps { get; set; }
        public virtual DbSet<glproj> glprojs { get; set; }
        public virtual DbSet<glstk> glstks { get; set; }
        public virtual DbSet<glstk_arc> glstk_arc { get; set; }
        public virtual DbSet<glstkdet> glstkdets { get; set; }
        public virtual DbSet<gltax> gltaxes { get; set; }
        public virtual DbSet<gltaxgrp> gltaxgrps { get; set; }
        public virtual DbSet<gst_custom> gst_custom { get; set; }
        public virtual DbSet<gstau> gstaus { get; set; }
        public virtual DbSet<gstmy> gstmies { get; set; }
        public virtual DbSet<gstmy_arc> gstmy_arc { get; set; }
        public virtual DbSet<gstmy_pe> gstmy_pe { get; set; }
        public virtual DbSet<gstsg> gstsgs { get; set; }
        public virtual DbSet<paymode> paymodes { get; set; }
        public virtual DbSet<paytype> paytypes { get; set; }
        public virtual DbSet<pgrn> pgrns { get; set; }
        public virtual DbSet<pgrndet> pgrndets { get; set; }
        public virtual DbSet<pinv> pinvs { get; set; }
        public virtual DbSet<pinvdet> pinvdets { get; set; }
        public virtual DbSet<porder> porders { get; set; }
        public virtual DbSet<porderdet> porderdets { get; set; }
        public virtual DbSet<prodbatch> prodbatches { get; set; }
        public virtual DbSet<prodbom> prodboms { get; set; }
        public virtual DbSet<prodbrand> prodbrands { get; set; }
        public virtual DbSet<prodext> prodexts { get; set; }
        public virtual DbSet<prodgrp> prodgrps { get; set; }
        public virtual DbSet<prodhprice> prodhprices { get; set; }
        public virtual DbSet<prodrprice> prodrprices { get; set; }
        public virtual DbSet<prodsgrp> prodsgrps { get; set; }
        public virtual DbSet<prodsn> prodsns { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<produom> produoms { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<promoter> promoters { get; set; }
        public virtual DbSet<reason> reasons { get; set; }
        public virtual DbSet<revalue> revalues { get; set; }
        public virtual DbSet<revaluedet> revaluedets { get; set; }
        public virtual DbSet<sdo> sdoes { get; set; }
        public virtual DbSet<sdodet> sdodets { get; set; }
        public virtual DbSet<sinv> sinvs { get; set; }
        public virtual DbSet<sinvdet> sinvdets { get; set; }
        public virtual DbSet<sinvpay> sinvpays { get; set; }
        public virtual DbSet<sorder> sorders { get; set; }
        public virtual DbSet<sorderdet> sorderdets { get; set; }
        public virtual DbSet<squote> squotes { get; set; }
        public virtual DbSet<squotedet> squotedets { get; set; }
        public virtual DbSet<stkt> stkts { get; set; }
        public virtual DbSet<stktsdet> stktsdets { get; set; }
        public virtual DbSet<stockloc> stocklocs { get; set; }
        public virtual DbSet<supervisor> supervisors { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<tax> taxes { get; set; }
        public virtual DbSet<udrpt> udrpts { get; set; }
        public virtual DbSet<udrptfilter> udrptfilters { get; set; }
        public virtual DbSet<udrptmodule> udrptmodules { get; set; }
        public virtual DbSet<udrptorder> udrptorders { get; set; }
        public virtual DbSet<usergrp> usergrps { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<usrgrpright> usrgrprights { get; set; }
        public virtual DbSet<defrptfile> defrptfiles { get; set; }
        public virtual DbSet<doclink> doclinks { get; set; }
        public virtual DbSet<gl> gls { get; set; }
        public virtual DbSet<glaudit> glaudits { get; set; }
        public virtual DbSet<glconsodet> glconsodets { get; set; }
        public virtual DbSet<gloff> gloffs { get; set; }
        public virtual DbSet<glrecur> glrecurs { get; set; }
        public virtual DbSet<prodtprice> prodtprices { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
        public virtual DbSet<stocksn> stocksns { get; set; }
    }
}

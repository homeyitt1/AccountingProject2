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
    
    public partial class usrgrpright
    {
        public string usrgrp_id { get; set; }
        public byte usrgrp_type { get; set; }
        public string itemid { get; set; }
        public string itemdesp { get; set; }
        public string itemtype { get; set; }
        public bool access { get; set; }
        public bool insertflag { get; set; }
        public bool updateflag { get; set; }
        public bool deleteflag { get; set; }
        public bool printflag { get; set; }
        public bool readflag { get; set; }
    }
}

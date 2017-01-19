using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingProject2.Models
{
    public class GldataGlgrpEntities
    {
        public gldata gldata { get; set; }
        public glgrp glgrp { get; set; }
        // public DbSet<gldata> gldata { get; set; }
        //public DbSet<glgrp> glgrp { get; set; }
        
        public List<SelectListItem> GlgroupItems { get; set; }
        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountingProject2.Models;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data;
using System.Data.Common;
namespace AccountingProject2.Controllers
{
    public class AccountingManagerController : Controller
    {

        recontestEntities gldataDB = new recontestEntities();

        // GET: AccountingManager
        public async Task<ActionResult> Index()
        {
            return View(await gldataDB.gldatas.ToListAsync());
        }

        public ActionResult Create()
        {
            ViewBag.grp_code = new SelectList(gldataDB.glgrps, "grp_code", "grp_desp");
            //ViewBag.GlgroupItems = gldataDB.glgrps.ToList().Select(x => new SelectListItem { Value = x.grp_code, Text = x.grp_desp });
            return View();
        }
        [HttpPost]
        public ActionResult Create(gldata gldata1)
        {
            if (ModelState.IsValid)
            {
                gldataDB.gldatas.Add(gldata1);
                gldataDB.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(gldata1);
        }


       ////please highlight
       // public async Task<ActionResult> Details(string id)
       // {
       //     //var conn = gldataDB.gldatas.GetDbConnection();
       //     if (ModelState.IsValid)
       //     {
       //         gldataDB.gldatas.Add(gldata1);
       //         gldataDB.SaveChanges();
       //         return RedirectToAction("Index");

       //     }
       //     return View(gldata1);
       // }

        //// GET: /AccountingManager/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    gldata gldata = gldataDB.gldatas.Find(id);
        //    PopulateGroupAccountList(gldata.grp_code);

        //    //IEnumerable<SelectListItem> items=gldataDB.glgrps.Select(z => new SelectListItem)

        //    //IEnumerable<SelectListItem> items = gldataDB.glgrps.Select(z => new SelectListItem
        //    //{
        //    //     Value = z.grp_code,
        //    //    Text = z.grp_desp
        //    // });
        //    // ViewBag.Dropdownlist = items;
        //    //ViewBag["grp_code"] = new SelectList(gldataDB.glgrps, "grp_code", "grp_code", gldata.grp_code);
        //    return View(gldata);
        //}

        //[HttpPost]
        //public ActionResult Edit(gldata gldata1)
        //{
        //    try { 
        //    if (ModelState.IsValid)
        //    {
        //        gldataDB.Entry(gldata).State = EntityState.Modified;
        //        gldataDB.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //        //ViewBag.grp_code = new SelectList(gldataDB.glgrps, "grp_code", "grp_code", gldata.grp_code);
        //    }
        //    catch (DataException /* dex */)
        //    {
        //        //Log the error (uncomment dex variable name after DataException and add a line here to write a log.)
        //        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
        //    }
        //    PopulateGroupAccountList(gldata.grp_code);


        //    return View(gldata);
        //}
        public ActionResult Edit(string id)
        {
           ViewBag.grp_code = new SelectList(gldataDB.glgrps, "grp_code", "grp_desp");
            
            var gldata1 = gldataDB.gldatas.Single(a => a.accno == id);
            //ViewBag.grp_code = gldata1.grp_code;
            return View(gldata1);
        }

        // POST: /AccountingManager/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            var gldata0 = gldataDB.gldatas.Find(id);
            
            //var gldata1 = gldataDB.gldatas.Single(a => a.accno == id);

            if (TryUpdateModel(gldata0))
            {
                // TODO: Add update logic here
                gldataDB.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.grp_code = new SelectList(gldataDB.glgrps, "grp_code", "grp_desp");
                //ViewBag.gldatas = gldataDB.gldatas.OrderBy(g => g.grp_code).ToList();
                return View(gldata0);
            }
        }

        // GET: /AccountingManager/Delete/5
        public ActionResult Delete(string id)
        {
            var gldata = gldataDB.gldatas.Find(id);
            return View(gldata);
        }

        // POST: /AccountingManager/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            var gldata = gldataDB.gldatas.Find(id);

            gldataDB.gldatas.Remove(gldata);
            gldataDB.SaveChanges();

            return View("Deleted");
        }


        

    }
}
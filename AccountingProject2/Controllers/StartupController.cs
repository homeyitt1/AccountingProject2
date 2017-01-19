using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingProject2.Controllers
{
    public class StartupController : Controller
    {
        // GET: Startup
        public ActionResult Index()
        {
            return View();
        }

        // GET: Startup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Startup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Startup/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Startup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Startup/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Startup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Startup/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

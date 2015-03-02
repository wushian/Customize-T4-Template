using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTemplate.Models;

namespace T4CustomizeTemplate.Controllers
{
    public class SampleController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /Sample/

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Sample/Create

        [HttpPost]
        public ActionResult Create(Sample sample)
        {
            if (ModelState.IsValid)
            {
                db.Samples.Add(sample);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sample);
        }

       
    }
}
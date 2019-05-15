using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using saavyTechWeb.Models;

namespace saavyTechWeb.Controllers
{
    public class JobsController : Controller
    {
        private DBModels db = new DBModels();

        public bool checkLoggedIn()
        {
            return Session["userid"] != null;
        }

        // GET: Jobs
        public ActionResult Index()
        {
            //Used to check if a user is logged in
            if (!checkLoggedIn())
            {
                return RedirectToAction("Index", "Login");
            }

            var jobs = db.Jobs.Include(j => j.Brand).Include(j => j.equiptmentType).Include(j => j.status);
           
            return View(jobs.ToList());
        }

        // GET: Jobs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jobs jobs = db.Jobs.Find(id);
            if (jobs == null)
            {
                return HttpNotFound();
            }
            return View(jobs);
        }

        // GET: Jobs/Create
        public ActionResult Create()
        {
            ViewBag.brandId = new SelectList(db.Brand, "Id", "brandName");
            ViewBag.equipmentTypeId = new SelectList(db.equiptmentType, "Id", "equiptmentName");
            ViewBag.statusId = new SelectList(db.status, "Id", "statusName");
            return View();
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,firstName,lastName,email,contact,equipmentTypeId,brandId,model,serial,issues,recepId,dateIn,techReport,techId,dateRepaired,statusId,dateCollected,jobNumber")] Jobs jobs)
        {
            if (ModelState.IsValid)
            {
                db.Jobs.Add(jobs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.brandId = new SelectList(db.Brand, "Id", "brandName", jobs.brandId);
            ViewBag.equipmentTypeId = new SelectList(db.equiptmentType, "Id", "equiptmentName", jobs.equipmentTypeId);
            ViewBag.statusId = new SelectList(db.status, "Id", "statusName", jobs.statusId);
            return View(jobs);
        }

        // GET: Jobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jobs jobs = db.Jobs.Find(id);
            if (jobs == null)
            {
                return HttpNotFound();
            }
            ViewBag.brandId = new SelectList(db.Brand, "Id", "brandName", jobs.brandId);
            ViewBag.equipmentTypeId = new SelectList(db.equiptmentType, "Id", "equiptmentName", jobs.equipmentTypeId);
            ViewBag.statusId = new SelectList(db.status, "Id", "statusName", jobs.statusId);
            return View(jobs);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,firstName,lastName,email,contact,equipmentTypeId,brandId,model,serial,issues,recepId,dateIn,techReport,techId,dateRepaired,statusId,dateCollected,jobNumber")] Jobs jobs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.brandId = new SelectList(db.Brand, "Id", "brandName", jobs.brandId);
            ViewBag.equipmentTypeId = new SelectList(db.equiptmentType, "Id", "equiptmentName", jobs.equipmentTypeId);
            ViewBag.statusId = new SelectList(db.status, "Id", "statusName", jobs.statusId);
            return View(jobs);
        }

        // GET: Jobs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jobs jobs = db.Jobs.Find(id);
            if (jobs == null)
            {
                return HttpNotFound();
            }
            return View(jobs);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jobs jobs = db.Jobs.Find(id);
            db.Jobs.Remove(jobs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

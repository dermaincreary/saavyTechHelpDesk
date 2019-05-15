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
    public class UsersController : Controller
    {
        private DBModels db = new DBModels();

        public bool checkLoggedIn()
        {
            return Session["userid"] != null;
        }

        // GET: Users
        public ActionResult Index()
        {
            //Used to check if a user is logged in
            if (!checkLoggedIn())
            {
                return RedirectToAction("Index", "Login");
            }


            var users = db.Users.Include(u => u.userRole);
            //var users = db.Users.Include(u => u.userRole).Where(q => q.roleId == Session["roleId"]);
            return View(users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.roleId = new SelectList(db.userRole, "Id", "role");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,firstName,lastName,phoneNumber,email,username,password,roleId,dateCreated")] Users user)
        {
            user.dateCreated = DateTime.Now.ToString("dd/MM/yyyy");

            //var pWord = $"{Session["fName"][0]}{lname}{rand.Next(10, 99)}";

            int rand = new Random().Next(100, 999);
            int rand2 = new Random().Next(10, 99);

            var pp = Session["fName"].ToString() + rand.ToString() + Session["lName"].ToString() + rand2.ToString();
            user.password = pp;

            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.roleId = new SelectList(db.userRole, "Id", "role", user.roleId);
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.roleId = new SelectList(db.userRole, "Id", "role", user.roleId);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,firstName,lastName,phoneNumber,email,username,password,roleId,dateCreated")] Users user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.roleId = new SelectList(db.userRole, "Id", "role", user.roleId);
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Users user = db.Users.Find(id);
            db.Users.Remove(user);
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

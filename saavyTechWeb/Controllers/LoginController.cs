using saavyTechWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace saavyTechWeb.Controllers
{
    public class LoginController : Controller
    {
        
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize([Bind(Include = "username,password")] Users user)
            {
            using (DBModels db = new DBModels())
            {
                var userDetails = db.Users.Where(l => l.username == user.username && l.password == user.password).FirstOrDefault();
                              
                if (userDetails == null)
                {
                    //user.LoginErrorMsg = "Username or Password is invalid";
                    ViewBag.Error = "Incorrect Credentials!";
                    return View("Index", user);
                }
                else
                {
                   

                    Session["fName"] = userDetails.firstName;
                    Session["lName"] = userDetails.lastName;
                    Session["roleid"] = userDetails.roleId;
                    Session["userid"] = userDetails.Id;

                    return RedirectToAction("Index", "Home");
                }
            }
        }

        

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
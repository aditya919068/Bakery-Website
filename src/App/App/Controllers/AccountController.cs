using App.Models;
using App.Utilities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMongoDatabase _database;
        public AccountController()
        {

        }
        // GET: Account
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUpModel signUp)
        {
            if (ModelState.IsValid)
            {
                signUp.Id = ProductHelper.GetUniqueKey();
                using (var context = new DBContext())
                {
                    var user = context.Users.Find(x => x.Email == signUp.Email).FirstOrDefault();
                    if (user != null)
                    {

                        ViewBag.Message = "User already exists!";
                    }
                    else
                    {
                        context.Users.InsertOne(signUp);
                        ViewBag.Message = "You have been registered successfully!";

                    }
                }

            }

            return View();
        }
        public ActionResult SignIn()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SignInModel signIn)
        {
            if (ModelState.IsValid)
            {
                using (var context = new DBContext())
                {
                    var user = context.Users.Find(x => x.Email == signIn.Email && x.Password == signIn.Password).FirstOrDefault();
                    if (user != null)
                    {
                        Session["user"] = user;
                        return RedirectToAction("Index", "Product");
                    }
                    else
                    {
                        ViewBag.Message = "Invalid credentials";

                    }
                }
            }
            return View();
        }
    }
}

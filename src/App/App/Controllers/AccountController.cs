using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class AccountController : Controller
    {
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

            }

            return View();
        }
        public ActionResult SignIn()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SignInModel signIn)
        {

            return View();
        }
    }
}

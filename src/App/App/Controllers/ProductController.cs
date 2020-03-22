using App.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(string keyword)
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("SignIn", "Account");

            }
            else
            {
                ViewBag.keyword = keyword;
                return View(string.IsNullOrEmpty(keyword) ? ProductHelper.GetProducts() : ProductHelper.GetProducts()
                    .Where(x => x.Name.ToLower().StartsWith(keyword.ToLower()) || x.Desc.ToLower().StartsWith(keyword.ToLower())).ToList());
            }

        }


       
    }
}

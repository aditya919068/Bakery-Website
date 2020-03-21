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
            ViewBag.keyword = keyword;
            return View(string.IsNullOrEmpty(keyword) ? ProductHelper.GetProducts() : ProductHelper.GetProducts()
                .Where(x => x.Name.ToLower().StartsWith(keyword.ToLower()) || x.Desc.ToLower().StartsWith(keyword.ToLower())).ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(ProductHelper.GetProducts().FirstOrDefault(x => x.Id == id));
        }
    }
}

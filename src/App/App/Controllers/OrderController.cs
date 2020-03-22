using App.Models;
using App.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(OrderModel items)
        {
            if (Session["user"] == null)
            {
                return Json("Please login first!", JsonRequestBehavior.AllowGet);
            

            }
            else
            {
                if (items != null)
                {
                    var user = (SignUpModel)Session["user"];
                    items.Id = ProductHelper.GetUniqueKey();
                    items.OrderDate = DateTime.Now;
                    items.DeliveryDate = DateTime.Now;
                    items.Status = "Order Delivered";
                    items.UserId = user.Id;
                    items.UserName = user.Name;
                    items.Address = user.Address;
                    using (var context = new DBContext())
                    {
                        context.Orders.InsertOne(items);
                    }
                        return Json("Done", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("Invalid items", JsonRequestBehavior.AllowGet);
                }

                
            }
        }
    }
}

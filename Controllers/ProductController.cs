using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab4.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            lab4Entities db = new lab4Entities();
           ViewBag.data = db.Product.ToList();
            return View();
        }
    }
}
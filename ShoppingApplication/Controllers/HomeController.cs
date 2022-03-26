using ShoppingApplication.BAL;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new ProductBAL().GetProducts());
        }
        public ActionResult ViewProduct()
        {
            return View();
        }
    }
}
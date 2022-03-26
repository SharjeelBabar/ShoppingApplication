using ShoppingApplication.BAL;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.Controllers
{
    public class SellerController : Controller
    {
        // GET: Seller
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            ViewBag.SubCategories = new ProductBAL().GetSubCategories();
            ViewBag.ProductStatuses = new ProductBAL().GetProductStatuses();
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product, HttpPostedFileBase file, List<HttpPostedFileBase> moreimages)
        {
            var UserId = new CommonController().GetUserInfo(Request);
            List<Image> Images = new List<Image>();
            if (file != null)
            {
                string uniquename = DateTime.UtcNow.Ticks + file.FileName;
                string path = Server.MapPath("~/Images/Products/") + uniquename;
                file.SaveAs(path);
                product.Image = "/Images/Products/" + uniquename;
            }
            product.SellerId = Convert.ToInt32(UserId);
            new ProductBAL().AddProduct(product);
            var count = 0;
            foreach (var Image in moreimages)
            {
                string uniquename = DateTime.UtcNow.Ticks + count++ + Image.FileName;
                string path = Server.MapPath("~/Images/Products/") + uniquename;
                Image.SaveAs(path);
                Images.Add(new Image { URL = "/Images/Products/" + uniquename, ProductId = product.Id });
            }
            if (Images.Any())
            {
                new ProductBAL().AddImages(Images);
            }
            return RedirectToAction("Products");
        }
        public ActionResult EditProduct(int Id)
        {
            ViewBag.Sellers = new UserBAL().GetSellers();
            ViewBag.SubCategories = new ProductBAL().GetSubCategories();
            ViewBag.ProductStatuses = new ProductBAL().GetProductStatuses();
            return View(new ProductBAL().GetProduct(Id));
        }
        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            new ProductBAL().EditProduct(product);
            return RedirectToAction("Products");
        }
        public ActionResult DeleteProduct(int Id)
        {
            new ProductBAL().DeleteProduct(Id);
            return RedirectToAction("Products");
        }
        public ActionResult MyProducts()
        {
            var UserId = new CommonController().GetUserInfo(Request);
            return View(new ProductBAL().GetMyProducts(Convert.ToInt32(UserId)));
        }
    }
}
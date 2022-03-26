using ShoppingApplication.BAL;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddRole(Role role)
        {
            new AdminBAL().AddRole(role);
            return RedirectToAction("Roles");
        }
        public ActionResult EditRole(int Id)
        {
            return View(new AdminBAL().GetRole(Id));
        }
        [HttpPost]
        public ActionResult EditRole(Role role)
        {
            new AdminBAL().EditRole(role);
            return RedirectToAction("Roles");
        }
        public ActionResult DeleteRole(int Id)
        {
            new AdminBAL().DeleteRole(Id);
            return RedirectToAction("Roles");
        }
        public ActionResult Roles()
        {
            return View(new AdminBAL().GetRoles());
        }
        public ActionResult AddUser()
        {
            ViewBag.Roles = new AdminBAL().GetRoles();
            return View();
        }
        [HttpPost]
        public ActionResult Adduser(User user)
        {
            new AdminBAL().AddUser(user);
            return RedirectToAction("Users");
        }
        public ActionResult EditUser(int Id)
        {
            ViewBag.Roles = new AdminBAL().GetRoles();
            return View(new AdminBAL().GetUser(Id));
        }
        [HttpPost]
        public ActionResult EditUser(User user)
        {
            new AdminBAL().EditUser(user);
            return RedirectToAction("Users");
        }
        public ActionResult DeleteUser(int Id)
        {
            new AdminBAL().DeleteUser(Id);
            return RedirectToAction("Users");
        }
        public ActionResult Users()
        {
            return View(new AdminBAL().GetUsers());
        }
        public ActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCity(City city)
        {
            new AdminBAL().AddCity(city);
            return RedirectToAction("Cities");
        }
        public ActionResult EditCity(int Id)
        {
            return View(new AdminBAL().GetCity(Id));
        }
        [HttpPost]
        public ActionResult EditCity(City city)
        {
            new AdminBAL().EditCity(city);
            return RedirectToAction("Cities");
        }
        public ActionResult DeleteCity(int Id)
        {
            new AdminBAL().DeleteCity(Id);
            return RedirectToAction("Cities");
        }
        public ActionResult Cities()
        {
            return View(new AdminBAL().GetCities());
        }
        public ActionResult AddAddressDetail()
        {
            ViewBag.Users = new AdminBAL().GetUsers();
            ViewBag.Cities = new AdminBAL().GetCities();
            return View();
        }
        [HttpPost]
        public ActionResult AddAddressDetail(AddressDetail addressDetail)
        {
            new AdminBAL().AddAddressDetail(addressDetail);
            return RedirectToAction("AddressDetails");
        }
        public ActionResult EditAddressDetail(int Id)
        {
            ViewBag.Users = new AdminBAL().GetUsers();
            ViewBag.Cities = new AdminBAL().GetCities();
            return View(new AdminBAL().GetAddressDetail(Id));
        }
        [HttpPost]
        public ActionResult EditAddressDetail(AddressDetail addressDetail)
        {
            new AdminBAL().EditAddressDetail(addressDetail);
            return RedirectToAction("AddressDetails");
        }
        public ActionResult DeleteAddressDetail(int Id)
        {
            new AdminBAL().DeleteAddressDetail(Id);
            return RedirectToAction("AddressDetails");
        }
        public ActionResult AddressDetails()
        {
            return View(new AdminBAL().GetAddressDetails());
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            new AdminBAL().AddCategory(category);
            return RedirectToAction("Categories");
        }
        public ActionResult EditCategory(int Id)
        {
            return View(new AdminBAL().GetCategory(Id));
        }
        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            new AdminBAL().EditCategory(category);
            return RedirectToAction("Categories");
        }
        public ActionResult DeleteCategory(int Id)
        {
            new AdminBAL().DeleteCategory(Id);
            return RedirectToAction("Categories");
        }
        public ActionResult Categories()
        {
            return View(new AdminBAL().GetCategories());
        }
        public ActionResult AddSubCategory()
        {
            ViewBag.Categories = new AdminBAL().GetCategories();
            return View();
        }
        [HttpPost]
        public ActionResult AddSubCategory(SubCategory subCategory)
        {
            new AdminBAL().AddSubCategory(subCategory);
            return RedirectToAction("SubCategories");
        }
        public ActionResult EditSubCategory(int Id)
        {
            ViewBag.Categories = new AdminBAL().GetCategories();
            return View(new AdminBAL().GetSubCategory(Id));
        }
        [HttpPost]
        public ActionResult EditSubCategory(SubCategory subCategory)
        {
            new AdminBAL().EditSubCategory(subCategory);
            return RedirectToAction("SubCategories");
        }
        public ActionResult DeleteSubCategory(int Id)
        {

            new AdminBAL().DeleteSubCategory(Id);
            return RedirectToAction("SubCategories");
        }
        public ActionResult SubCategories()
        {
            return View(new AdminBAL().GetSubCategories());
        }
        public ActionResult AddProductStatus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProductStatus(ProductStatus productStatus)
        {
            new AdminBAL().AddProudctStatus(productStatus);
            return RedirectToAction("ProductStatuses");
        }
        public ActionResult EditProductStatus(int Id)
        {
            return View(new AdminBAL().GetProductStatus(Id));
        }
        [HttpPost]
        public ActionResult EditProductStatus(ProductStatus productStatus)
        {
            new AdminBAL().EditProductStatus(productStatus);
            return RedirectToAction("ProductStatuses");
        }
        public ActionResult DeleteProductStatus(int Id)
        {
            new AdminBAL().DeleteProductStatus(Id);
            return RedirectToAction("ProductStatuses");
        }
        public ActionResult ProductStatuses()
        {
            return View(new AdminBAL().GetProductStatuses());
        }
        public ActionResult AddProduct()
        {
            ViewBag.Sellers = new AdminBAL().GetSellers();
            ViewBag.SubCategories = new AdminBAL().GetSubCategories();
            ViewBag.ProductStatuses = new AdminBAL().GetProductStatuses();
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product, HttpPostedFileBase file, List<HttpPostedFileBase> moreimages)
        {
            List<Image> Images = new List<Image>();
            if (file != null)
            {
                string uniquename = DateTime.UtcNow.Ticks + file.FileName;
                string path = Server.MapPath("~/Images/Products/") + uniquename;
                file.SaveAs(path);
                product.Image = "/Images/Products/" + uniquename;
            }
            new AdminBAL().AddProduct(product);
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
            ViewBag.Sellers = new AdminBAL().GetSellers();
            ViewBag.SubCategories = new AdminBAL().GetSubCategories();
            ViewBag.ProductStatuses = new AdminBAL().GetProductStatuses();
            return View(new AdminBAL().GetProduct(Id));
        }
        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            new AdminBAL().EditProduct(product);
            return RedirectToAction("Products");
        }
        public ActionResult DeleteProduct(int Id)
        {
            new AdminBAL().DeleteProduct(Id);
            return RedirectToAction("Products");
        }
        public ActionResult Products()
        {
            return View(new AdminBAL().GetProducts());
        }
        public ActionResult AddOrderStatus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddOrderStatus(OrderStatus orderStatus)
        {
            new AdminBAL().AddOrderStatus(orderStatus);
            return RedirectToAction("OrderStatuses");
        }
        public ActionResult EditOrderStatus(int Id)
        {
            return View(new AdminBAL().GetOrderStatus(Id));
        }
        [HttpPost]
        public ActionResult EditOrderStatus(OrderStatus orderStatus)
        {
            new AdminBAL().EditOrderStatus(orderStatus);
            return RedirectToAction("OrderStatuses");
        }
        public ActionResult DeleteOrderStatus(int Id)
        {
            new AdminBAL().DeleteOrderStatus(Id);
            return RedirectToAction("OrderStatuses");
        }
        public ActionResult OrderStatuses()
        {
            return View(new AdminBAL().GetOrderStatuses());
        }
        public ActionResult AddOrder()
        {
            ViewBag.Products = new AdminBAL().GetProducts();
            ViewBag.Buyers = new AdminBAL().GetBuyers();
            ViewBag.OrderStatuses = new AdminBAL().GetOrderStatuses();
            return View();
        }
        [HttpPost]
        public ActionResult AddOrder(Order order)
        {
            new AdminBAL().AddOrder(order);
            return RedirectToAction("Orders");
        }
        public ActionResult EditOrder(int Id)
        {
            ViewBag.Products = new AdminBAL().GetProducts();
            ViewBag.Buyers = new AdminBAL().GetBuyers();
            ViewBag.OrderStatuses = new AdminBAL().GetOrderStatuses();
            return View(new AdminBAL().GetOrder(Id));
        }
        [HttpPost]
        public ActionResult EditOrder(Order order)
        {
            new AdminBAL().EditOrder(order);
            return RedirectToAction("Orders");
        }
        public ActionResult DeleteOrder(int Id)
        {
            new AdminBAL().DeleteOrder(Id);
            return RedirectToAction("Orders");
        }
        public ActionResult Orders()
        {
            return View(new AdminBAL().GetOrders());
        }
    }
}
using ShoppingApplication.BAL;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            new AccountBAL().Register(user);
            HttpCookie httpCookie = new HttpCookie("user-access-token");
            httpCookie.Value = user.AccessToken;
            Response.Cookies.Remove("user-access-token");
            Response.Cookies.Add(httpCookie);

            return Redirect("~/Home/Index");
        }
        public bool CheckEmail(string email)
        { 
            return new AccountBAL().CheckEmail(email);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            var DBUser = new AccountBAL().GetUserForLogin(Email,Password);
            if (DBUser != null)
            {
                HttpCookie httpCookie = new HttpCookie("user-access-token");
                httpCookie.Value = DBUser.AccessToken;
                Response.Cookies.Remove("user-access-token");
                Response.Cookies.Add(httpCookie);

                return Redirect("~/Home/Index");
            }
            ViewBag.Error = "Your Email or Password is Incorrect";
            return View();
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Response.Cookies.Get("user-access-token").Expires = DateTime.UtcNow.AddDays(-1);
            return Redirect("~/Home/Index");
        }
    }
}
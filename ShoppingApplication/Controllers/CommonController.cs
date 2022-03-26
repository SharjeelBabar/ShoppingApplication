using ShoppingApplication.BAL;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public User GetUserInfo(HttpRequestBase requestBase)
        {
            HttpCookie httpCookie = requestBase.Cookies.Get("user-access-token");
            if (httpCookie != null)
            {
                User user = new AccountBAL().GetUserInfo(httpCookie.Value);
                if (user != null)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
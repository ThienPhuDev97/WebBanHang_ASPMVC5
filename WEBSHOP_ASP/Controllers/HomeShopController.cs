using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBSHOP_ASP.Controllers
{
    public class HomeShopController : Controller
    {
        // GET: HomeShop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult ProductDetail()
        {
            return View();
        }
        public ActionResult ShopCart()
        {
            return View();
        }
    }
}
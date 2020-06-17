using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Service;

namespace OnlineShoppingSystem.Controllers
{
    public class HomeController : Controller
    {
        private ShoppingService shoppingService = new ShoppingService();

        // GET: Home
        public ActionResult Home()
        {
            Session["Category"] = shoppingService.GetListCategories();
            return View(shoppingService.GetListProducts());
        }
    }
}
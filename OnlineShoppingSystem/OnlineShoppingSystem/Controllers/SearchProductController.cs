using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingSystem.Service;

namespace OnlineShoppingSystem.Controllers
{
    public class SearchProductController : Controller
    {
        private ShoppingService shoppingService = new ShoppingService();

        //GET : SearchProduct
        public ActionResult Search()
        {
            return View();
        }

        // POST: SearchProduct
        [HttpPost]
        public ActionResult Search(string searchKey)
        {
            ViewBag.SearchKey = shoppingService.SearchProduct(searchKey);
            return View();
        }
    }
}
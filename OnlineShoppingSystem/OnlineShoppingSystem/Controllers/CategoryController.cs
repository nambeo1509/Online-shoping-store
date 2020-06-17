using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingSystem.Service;

namespace OnlineShoppingSystem.Controllers
{
    public class CategoryController : Controller
    {
        private ShoppingService shoppingService = new ShoppingService();

        public ActionResult ShowCategory(long id)
        {
            Session["CategoryName"] = shoppingService.GetSpecificCategory(id);
            if (shoppingService.GetProductsByCategory(id) != null)
            {
                return View(shoppingService.GetProductsByCategory(id));
            }

            return View();
        }
    }
}
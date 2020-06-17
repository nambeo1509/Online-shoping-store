using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingSystem.Service;

namespace OnlineShoppingSystem.Controllers
{
    public class ProductDetailsController : Controller
    {
        private ShoppingService shoppingService = new ShoppingService();

        public ActionResult ShowDetailProduct(long id)
        {
            Session["RelatedProduct"] = shoppingService.GetRandomProductByCategory(id);
            return View(shoppingService.GetDetailProduct(id));
        }
    }
}
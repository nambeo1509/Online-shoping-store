using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingSystem.Dao;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Service;

namespace OnlineShoppingSystem.Controllers
{
    public class CartController : Controller
    {
        private ShoppingCartService shoppingCartService = new ShoppingCartService();
        private const string CartSession = "CartSession";

        // GET: Cart
        public ActionResult ShowCart()
        {
            var cart = Session[CartSession];
            var listCart = (List<ShoppingCartDto>) cart;

            return View(listCart);
        }

        // Add products to Cart
        public ActionResult AddToCart(long productId, int quantity)
        {
            var account = (User) Session["Account"];
            if (account == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var cart = Session[CartSession];
            Session[CartSession] = shoppingCartService.AddToCart(productId, quantity, account, cart);
            return RedirectToAction("ShowCart");
        }

        //Remove all items
        public ActionResult RemoveAllItems()
        {
            Session.Remove(CartSession);
            return RedirectToAction("ShowCart");
        }

        //Remove one item
        public ActionResult RemoveSpecificItem(long id)
        {
            var listCart = (List<ShoppingCartDto>) Session[CartSession];
            listCart.RemoveAll(x => x.ProductId == id);
            Session[CartSession] = listCart;

            return RedirectToAction("ShowCart");
        }
    }
}
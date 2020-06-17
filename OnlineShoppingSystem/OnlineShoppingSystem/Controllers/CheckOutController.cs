using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Service;

namespace OnlineShoppingSystem.Controllers
{
    public class CheckOutController : Controller
    {
        private OrderService orderService = new OrderService();
        private const string CartSession = "CartSession";

        //Show CheckOut
        public ActionResult ShowCheckOut()
        {
            var cart = Session[CartSession];
            var listCart = (List<ShoppingCartDto>) cart;

            return View(listCart);
        }

        //Save order into database
        public ActionResult CheckOut()
        {
            var cart = Session[CartSession];
            var listCart = (List<ShoppingCartDto>) cart;
            orderService.AddOrder(listCart);
            Session.Remove(CartSession);
            Session.Remove("NumberOfProductInCart");

            return RedirectToAction("GetMessagePlaceOrder");
        }

        //Show message for successful order
        public ActionResult GetMessagePlaceOrder()
        {
            return View();
        }

        //Show order for customer
        public ActionResult ShowOrder()
        {
            var account = (User) Session["Account"];
            return View(orderService.GetOrder(account));
        }

        //Show detail order
        public ActionResult ShowOrderDetail(long orderId)
        {
            return View(orderService.GetOrderDetails(orderId));
        }
    }
}
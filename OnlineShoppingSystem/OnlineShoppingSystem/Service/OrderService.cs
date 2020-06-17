using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingSystem.Dao;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Service
{
    public class OrderService
    {
        private OrderDao orderDao = new OrderDao();

        /// <summary>
        /// Save order of Customer into database
        /// </summary>
        /// <param name="cart"></param>
        public void AddOrder(List<ShoppingCartDto> cart)
        {
            orderDao.AddOrder(cart);
        }

        /// <summary>
        /// Get all orders
        /// </summary>
        /// <returns></returns>
        public List<Order> GetOrder(User user)
        {
            return orderDao.GetOrder(user);
        }

        /// <summary>
        /// Get order details
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public List<ShoppingCartDto> GetOrderDetails(long orderId)
        {
            return orderDao.GetOrderDetail(orderId);
        }
    } 
}
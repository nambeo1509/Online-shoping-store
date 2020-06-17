using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingSystem.Dao;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Service
{
    public class ShoppingCartService
    {
        private ShoppingCartDao shoppingCartDao = new ShoppingCartDao();

        /// <summary>
        /// Bring product selected into cart and get information of user who buy this product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        public List<ShoppingCartDto> AddToCart(long id, int quantity, User user, object session)
        {
            return shoppingCartDao.AddToCart(id, quantity, user, session);
        }
    }
}
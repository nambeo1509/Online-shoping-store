using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Dao
{
    public class ShoppingCartDao
    {
        public List<ShoppingCartDto> AddToCart(long id, int quantity, User user, object session)
        {
            List<ShoppingCartDto> listItem = new List<ShoppingCartDto>();
            var product = new ShoppingDao().GetDetailProduct(id);
            if (session != null)
            {
                listItem = (List<ShoppingCartDto>) session;
                if (listItem.Exists(x => x.ProductId == id))
                {
                    foreach (var item in listItem)
                    {
                        if (item.ProductId == id)
                        {
                            item.Quantity += quantity;
                            item.TotalPrice = item.Quantity * item.Price;
                        }
                    }
                }
                else
                {
                    var newCart = new ShoppingCartDto();
                    long orderId = new OrderDao().GetOrderId() + 1;
                    newCart.OrderId = orderId;
                    newCart.CustomerId = user.UserID;
                    newCart.ProductId = product.ProductID;
                    newCart.ProductName = product.ProductName;
                    newCart.Image = product.Image;
                    newCart.Price = product.Price;
                    newCart.Quantity = quantity;
                    newCart.TotalPrice = product.Price * newCart.Quantity;
                    newCart.CustomerName = user.Name;
                    newCart.Address = user.Address;
                    newCart.Phone = user.Phone;
                    newCart.Email = user.Email;
                    listItem.Add(newCart);
                }
            }
            else
            {
                var newCart = new ShoppingCartDto();
                long orderId = new OrderDao().GetOrderId() + 1;
                newCart.OrderId = orderId;
                newCart.CustomerId = user.UserID;
                newCart.ProductId = product.ProductID;
                newCart.ProductName = product.ProductName;
                newCart.Image = product.Image;
                newCart.Price = product.Price;
                newCart.Quantity = quantity;
                newCart.TotalPrice = product.Price * newCart.Quantity;
                newCart.CustomerName = user.Name;
                newCart.Address = user.Address;
                newCart.Phone = user.Phone;
                newCart.Email = user.Email;
                listItem.Add(newCart);
            }

            return listItem;
        }
    }
}
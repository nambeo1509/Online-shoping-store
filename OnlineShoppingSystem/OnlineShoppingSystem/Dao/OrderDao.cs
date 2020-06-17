using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Dao
{
    public class OrderDao
    {
        public long GetOrderId()
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var order = (from o in dbContext.Orders select o.OrderID).ToList();
                long orderId = 0;
                if (order.Count == 0)
                {
                    return 0;
                }

                foreach (var item in order)
                {
                    orderId = item;
                }

                return orderId;
            }
        }

        public void AddOrder(List<ShoppingCartDto> cart)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var tempOrder = (from c in cart select c).Distinct().ToList();
                Order order = new Order();
                foreach (var item in tempOrder)
                {
                    order.OrderID = item.OrderId;
                    order.CreatedDate = DateTime.Now;
                    order.CustomerID = item.CustomerId;
                    order.ShipName = item.CustomerName;
                    order.ShipAddress = item.Address;
                    order.ShipMobile = item.Phone;
                    order.ShipEmail = item.Email;
                }

                dbContext.Orders.Add(order);;
                dbContext.SaveChanges();

                List<OrderDetail> listOrderDetails = new List<OrderDetail>();
                OrderDetail orderDetail;
                foreach (var item in cart)
                {
                    orderDetail = new OrderDetail();
                    orderDetail.ProductID = item.ProductId;
                    orderDetail.OrderID = item.OrderId;
                    orderDetail.Quantity = item.Quantity;
                    orderDetail.Price = item.TotalPrice;
                    listOrderDetails.Add(orderDetail);
                }

                foreach (var item in listOrderDetails)
                {
                    dbContext.OrderDetails.Add(item);
                }

                dbContext.SaveChanges();
            }
        }

        public List<Order> GetOrder(User user)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                return (from o in dbContext.Orders
                        where user.UserID == o.CustomerID
                        select o).ToList();
            }
        }

        public List<ShoppingCartDto> GetOrderDetail(long orderId)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var order = (from od in dbContext.OrderDetails
                    join o in dbContext.Orders on od.OrderID equals o.OrderID
                    join p in dbContext.Products on od.ProductID equals p.ProductID
                    where od.OrderID == orderId
                    select new ShoppingCartDto()
                    {
                        OrderId = o.OrderID,
                        CustomerId = o.CustomerID,
                        ProductId = p.ProductID,
                        ProductName = p.ProductName,
                        Quantity = od.Quantity,
                        Price = p.Price,
                        TotalPrice = od.Price,
                        Image = p.Image,
                        CustomerName = o.ShipName,
                        Address = o.ShipAddress,
                        Phone = o.ShipMobile,
                        Email = o.ShipEmail,
                        CreatedDate = o.CreatedDate
                    }).ToList();

                return order;
            }
        }
    }
}
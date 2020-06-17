using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingSystem.Dao;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Service
{
    public class ShoppingService
    {
        private ShoppingDao shoppingDao = new ShoppingDao();

        /// <summary>
        /// Get all Products from database
        /// </summary>
        /// <returns></returns>
        public List<Product> GetListProducts()
        {
            return shoppingDao.GetListProducts();
        }

        /// <summary>
        /// Get list of Category
        /// </summary>
        /// <returns></returns>
        public List<Category> GetListCategories()
        {
            return shoppingDao.GetListCategories();
        }

        /// <summary>
        /// Get all Products by Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Product> GetProductsByCategory(long id)
        {
            return shoppingDao.GetProductsByCategory(id);
        }

        /// <summary>
        /// Get specific category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetSpecificCategory(long id)
        {
            return shoppingDao.GetSpecificCategory(id);
        }

        /// <summary>
        /// Get detail information of Product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product GetDetailProduct(long productId)
        {
            return shoppingDao.GetDetailProduct(productId);
        }

        /// <summary>
        /// Related Product in product details page
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Product> GetRandomProductByCategory(long id)
        {
            return shoppingDao.GetRandomProductByCategory(id);
        }

        /// <summary>
        /// Search product by Manufacture or Product Name
        /// </summary>
        /// <param name="searchKeyword"></param>
        /// <returns></returns>
        public List<Product> SearchProduct(string searchKeyword)
        {
            return shoppingDao.SearchProduct(searchKeyword);
        }
    }
}
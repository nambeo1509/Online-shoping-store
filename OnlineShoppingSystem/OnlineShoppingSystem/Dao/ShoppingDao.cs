using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Dao
{
    public class ShoppingDao
    {
        public List<Product> GetListProducts()
        {
            List<Product> listProducts = new List<Product>();
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                listProducts = (from p in dbContext.Products
                                select p).ToList();
            }

            return listProducts;
        }

        public List<Category> GetListCategories()
        {
            List<Category> listCategories = new List<Category>();
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                listCategories = (from c in dbContext.Categories
                                  select c).ToList();
            }

            return listCategories;
        }

        public List<Product> GetProductsByCategory(long id)
        {
            List<Product> listProducts = new List<Product>();
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                listProducts = (from p in dbContext.Products
                                join c in dbContext.Categories on p.CategoryID equals c.CategoryID
                                where p.CategoryID == id
                                select p).ToList();
            }

            return listProducts;
        }

        public string GetSpecificCategory(long id)
        {
            string categoryName = "";
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                categoryName = (from p in dbContext.Products
                               join c in dbContext.Categories on p.CategoryID equals c.CategoryID
                               where p.CategoryID == id
                               select c.CategoryName).FirstOrDefault();
            }

            return categoryName;
        }

        public Product GetDetailProduct(long productId)
        {
            Product product = new Product();
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                product = (from p in dbContext.Products
                           where p.ProductID == productId
                           select p).FirstOrDefault();
            }

            return product;
        }

        public List<Product> GetRandomProductByCategory(long id)
        {
            List<Product> listProducts = new List<Product>();
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                long categoryId = (from p in dbContext.Products
                                   join c in dbContext.Categories on p.CategoryID equals c.CategoryID
                                   where p.ProductID == id
                                   select c.CategoryID).FirstOrDefault();
                listProducts = (from p in dbContext.Products
                                join c in dbContext.Categories on p.CategoryID equals c.CategoryID
                                where p.CategoryID == categoryId && p.ProductID != id
                                select p).OrderBy(x => Guid.NewGuid()).ToList();
            }

            return listProducts;
        }

        public List<Product> SearchProduct(string searchKeyword)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var listSearchProduct = (from p in dbContext.Products
                                         where p.ProductName.Contains(searchKeyword) || p.Manufacturer.Equals(searchKeyword)
                                         select p).ToList();
                return listSearchProduct;
            }
        }
    }
}
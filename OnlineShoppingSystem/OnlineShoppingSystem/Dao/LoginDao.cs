using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Dao
{
    public class LoginDao
    {
        public bool CheckLogin(User user)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var account = (from a in dbContext.Users
                               where a.UserName == user.UserName && a.Password == user.Password
                               select a).FirstOrDefault();
                if (account != null)
                {
                    return true;
                }
            }

            return false;
        }

        public User GetUser(string userName, string password)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var account = (from a in dbContext.Users
                    where a.UserName == userName && a.Password == password
                    select a).FirstOrDefault();
                return account;
            }
        }

        public string GetName(User user)
        {
            string name = "";
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                name = (from a in dbContext.Users
                        where a.UserName == user.UserName && a.Password == user.Password
                        select a.Name).FirstOrDefault();
            }

            return name;
        }
    }
}
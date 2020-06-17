using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Dao
{
    public class AccountDao
    {
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

        public long GetLastUserId()
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var listUserId = (from u in dbContext.Users select u.UserID).ToList();
                long lastUserId = 0;
                foreach (var item in listUserId)
                {
                    lastUserId = item;
                }

                return lastUserId;
            }
        }

        public bool CheckDuplicatedUserName(string username)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var existedAccount = (from u in dbContext.Users
                                      where u.UserName == username
                                      select u).FirstOrDefault();
                if (existedAccount != null)
                {
                    return true;
                }

                return false;
            }
        }

        public void CreateAccount(User user)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var newUser = user;
                newUser.UserID = GetLastUserId() + 1;
                newUser.Role = false;
                newUser.CreatedDate = DateTime.Now;
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
            }
        }

        public void EditAccount(User user)
        {
            using (var dbContext = new OnlineShoppingSystemEntities())
            {
                var newUser = user;
                newUser.ModifiedDate = DateTime.Now;
                dbContext.Entry(newUser).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
    }
}
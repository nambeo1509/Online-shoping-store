using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingSystem.Dao;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Service
{
    public class LoginServices
    {
        private LoginDao loginDao = new LoginDao();

        /// <summary>
        /// Check Account is existed or not
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool CheckLogin(User user)
        {
            return loginDao.CheckLogin(user);
        }

        /// <summary>
        /// Get Name of account after login successfully
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string GetName(User user)
        {
            return loginDao.GetName(user);
        }

        /// <summary>
        /// Get information of Customer when login is successful
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User GetUser(string userName, string password)
        {
            return loginDao.GetUser(userName, password);
        }
    }
}
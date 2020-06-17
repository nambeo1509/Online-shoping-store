using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingSystem.Dao;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Service
{
    public class AccountService
    {
        private AccountDao accountDao = new AccountDao();

        /// <summary>
        /// Get id of last Customer stored in database
        /// </summary>
        /// <returns></returns>
        public long GetLastUserId()
        {
            return accountDao.GetLastUserId();
        }

        /// <summary>
        /// Check username is existed in database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckDuplicatedAccount(string username)
        {
            return accountDao.CheckDuplicatedUserName(username);
        }

        /// <summary>
        /// Add new user into database
        /// </summary>
        /// <param name="user"></param>
        public void CreateAccount(User user)
        {
            accountDao.CreateAccount(user);
        }

        /// <summary>
        /// Edit existed user
        /// </summary>
        /// <param name="user"></param>
        public void EditAccount(User user)
        {
            accountDao.EditAccount(user);
        }

        /// <summary>
        /// Get information of user after updated
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User GetUserAfterUpdated(string username, string password)
        {
            return accountDao.GetUser(username, password);
        }

        /// <summary>
        /// Get name user after updated
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string GetNameUserAfterUpdated(User user)
        {
            return accountDao.GetName(user);
        }
    }
}
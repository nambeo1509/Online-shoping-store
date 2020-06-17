using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Service;
using OnlineShoppingSystem.CommonUtils;

namespace OnlineShoppingSystem.Controllers
{
    public class LoginController : Controller
    {
        private LoginServices loginService = new LoginServices();

        //GET: Login
        public ActionResult Login()
        {
            return View();
        }

        //POST: Login
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (loginService.CheckLogin(user))
            {
                Session["Name"] = loginService.GetName(user);
                Session["Account"] = loginService.GetUser(user.UserName, user.Password);
                return RedirectToAction("Home", "Home");
            }
            else
            {
                if (EmptyUtil.CheckEmpty(user.UserName) || EmptyUtil.CheckEmpty(user.Password))
                {
                    ModelState.AddModelError("", "Hãy nhập tài khoản hoặc mật khẩu!");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng!");
                }
            }

            return View();
        }

        //Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Home", "Home");
        }
    }
}

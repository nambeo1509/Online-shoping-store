using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Service;

namespace OnlineShoppingSystem.Controllers
{
    public class AccountController : Controller
    {
        private AccountService accountService = new AccountService();

        // GET: Register Account
        public ActionResult CreateAccount()
        {
            Session["AutoRedirect"] = false;
            ViewBag.SuccessMessage = "";
            return View();
        }

        //POST: Register Account
        [HttpPost]
        public ActionResult CreateAccount(User user)
        {
            if (accountService.CheckDuplicatedAccount(user.UserName))
            {
                ModelState.AddModelError("", "Tài khoản này đã tồn tại!");
                return View();
            }

            accountService.CreateAccount(user);
            Session["AutoRedirect"] = true;
            ViewBag.SuccessMessage = "Đăng ký tài khoản mới thành công, xin vui lòng đợi 5s";
            return View();
        }

        //GET: Detail information of customer
        public ActionResult DetailAccount()
        {
            var account = (User) Session["Account"];
            return View(account);
        }

        //GET: Edit Account
        public ActionResult EditAccount()
        {
            var account = (User) Session["Account"];
            return View(account);
        }

        //POST: Edit Account
        [HttpPost]
        public ActionResult EditAccount(User user)
        {
            accountService.EditAccount(user);
            Session["Account"] = accountService.GetUserAfterUpdated(user.UserName, user.Password);
            Session["Name"] = accountService.GetNameUserAfterUpdated(user);
            return RedirectToAction("DetailAccount");
        }
    }
}
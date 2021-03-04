using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        // GET: Login
        public ActionResult Manager_Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var result = userManager.Find(user.UserName, user.Password);
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Index", "ManagerPanel");
            }
            else
            {
                ViewBag.mesaj = "Geçersiz kullanıcı";
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Manager_Login");
        }
    }
}
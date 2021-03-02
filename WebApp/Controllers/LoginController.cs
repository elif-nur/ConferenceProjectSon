using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View();
        }
    }
}
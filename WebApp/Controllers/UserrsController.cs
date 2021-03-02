﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class UserrsController : Controller
    {
        // GET: Userrs
        UserManager userManager = new UserManager(new EfUserDal());
        public ActionResult Index()
        {
            List<User> model = userManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            userManager.Add(user);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(User user)
        {
            var deger = userManager.Get(user.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(User user)
        {
            userManager.Update(user);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(User user)
        {
            userManager.Delete(user);
            return RedirectToAction("Index");
        }
    }
}
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
    public class FirsttController : Controller
    {
        // GET: Firstt

        FirstPageManager firstPageManager = new FirstPageManager(new EfFirstPageDal());
        public ActionResult Index()
        {
            List<FirstPage> model = firstPageManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FirstPage firstPage)
        {
            firstPageManager.Add(firstPage);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(FirstPage firstPage)
        {
            var deger = firstPageManager.Get(firstPage.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(FirstPage firstPage)
        {
            firstPageManager.Update(firstPage);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(FirstPage firstPage)
        {
            firstPageManager.Delete(firstPage);
            return RedirectToAction("Index");
        }
    }
}
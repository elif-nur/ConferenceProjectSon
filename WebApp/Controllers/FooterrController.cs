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
    public class FooterrController : Controller
    {
        // GET: Footer
        FooterManager footerManager = new FooterManager(new EfFooterDal());

        public ActionResult Index()
        {
            List<Footer> model = footerManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Footer footer)
        {
            footerManager.Add(footer);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(Footer footer)
        {
            var deger = footerManager.Get(footer.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(Footer footer)
        {
            footerManager.Update(footer);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Footer footer)
        {
            footerManager.Delete(footer);
            return RedirectToAction("Index");
        }
    }
}
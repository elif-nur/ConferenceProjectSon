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
    public class ScientificController : Controller
    {
        // GET: Scientific
        ScientificManager scientificManager = new ScientificManager(new EfScientificDal());
        public ActionResult Index()
        {
            List<Scientific> model = scientificManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Scientific scientific)
        {
            scientificManager.Add(scientific);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(Scientific scientific)
        {
            var deger = scientificManager.Get(scientific.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(Scientific scientific)
        {
            scientificManager.Update(scientific);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Scientific scientific)
        {
            scientificManager.Delete(scientific);
            return RedirectToAction("Index");
        }
    }
}
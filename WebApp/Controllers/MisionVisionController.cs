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
    public class MisionVisionController : Controller
    {
        // GET: MisionVision
        MisionVisionManager misionVisionManager = new MisionVisionManager(new EfMisionVisionDal());

        public ActionResult Index()
        {
            List<MisionVision> model = misionVisionManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MisionVision misionVision )
        {
            misionVisionManager.Add(misionVision);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(MisionVision misionVision)
        {
            var deger = misionVisionManager.Get(misionVision.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(MisionVision misionVision)
        {
            misionVisionManager.Update(misionVision);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(MisionVision misionVision)
        {
            misionVisionManager.Delete(misionVision);
            return RedirectToAction("Index");
        }
    }
}
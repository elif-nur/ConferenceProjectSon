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
    public class OrganisingController : Controller
    {
         OrganisingManager organisingManager = new OrganisingManager(new EfOrganisingDal());// GET: Organising
       
        public ActionResult Index()
        {
            List<OrganisingSpeaker> model = organisingManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(OrganisingSpeaker organisingSpeaker)
        {
            if (ModelState.IsValid)
            {
                organisingManager.Add(organisingSpeaker);
                return RedirectToAction("Index");
            }
            return View();
           
        }
        public ActionResult Bring(OrganisingSpeaker organisingSpeaker)
        {
            var deger = organisingManager.Get(organisingSpeaker.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(OrganisingSpeaker organisingSpeaker)
        {
            organisingManager.Update(organisingSpeaker);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(OrganisingSpeaker organisingSpeaker)
        {
            organisingManager.Delete(organisingSpeaker);
            return RedirectToAction("Index");
        }
    }
}
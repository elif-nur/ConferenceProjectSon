using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class SponsorrController : Controller
    {
        // GET: Sponsorr
        SponsorManager sponsorManager = new SponsorManager(new EfSponsorDal());
        public ActionResult Index()
        {
            List<Sponsor> model = sponsorManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Sponsor sponsor)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Images/"+dosyaadi+uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                sponsor.ImagePath = "/Images/" + dosyaadi + uzanti;
            }
            sponsorManager.Add(sponsor);
            return RedirectToAction("Index","Sponsorr");

        }

        public ActionResult Delete(Sponsor sponsor)
        {
            sponsorManager.Delete(sponsor);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(Sponsor sponsor)
        {
            var deger = sponsorManager.Get(sponsor.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(Sponsor sponsor)
        {
            sponsorManager.Update(sponsor);
            return RedirectToAction("Index");
        }
    }
}
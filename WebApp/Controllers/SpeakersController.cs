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
    public class SpeakersController : Controller
    {
        // GET: Speakers
        InvitedSpeakerManager invitedSpeakerManager = new InvitedSpeakerManager(new EfInvitedSpeakerDal());
        public ActionResult Index()
        {
            List<InvitedSpeaker> model = invitedSpeakerManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(InvitedSpeaker invitedSpeaker)
        {
            invitedSpeakerManager.Add(invitedSpeaker);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(InvitedSpeaker invitedSpeaker)
        {
            var deger = invitedSpeakerManager.Get(invitedSpeaker.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(InvitedSpeaker invitedSpeaker)
        {
            invitedSpeakerManager.Update(invitedSpeaker);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(InvitedSpeaker invitedSpeaker)
        {
            invitedSpeakerManager.Delete(invitedSpeaker);
            return RedirectToAction("Index");
        }
    }
}
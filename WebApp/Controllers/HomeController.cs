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
    public class HomeController : Controller
    {
        TopicManager topicManager = new TopicManager(new EfTopicDal());
        InvitedSpeakerManager invitedSpeakerManager = new InvitedSpeakerManager(new EfInvitedSpeakerDal());
        ScientificManager scientificManager = new ScientificManager(new EfScientificDal());
        OrganisingManager organisingManager = new OrganisingManager(new EfOrganisingDal());
        ProgramManager programManager = new ProgramManager(new EfProgramDal());
        MisionVisionManager misionVisionManager = new MisionVisionManager(new EfMisionVisionDal());
        FirstPageManager firstPageManager = new FirstPageManager(new EfFirstPageDal());
        ContactManager contactManager = new ContactManager(new EfContactDal());
        RegistrationManager registrationManager = new RegistrationManager(new EfRegistrationDal());
        InformationManager informationManager = new InformationManager(new EfInformationDal());
        SponsorManager sponsorManager = new SponsorManager(new EfSponsorDal());
        public ActionResult Index()
        {
            List<FirstPage> model = firstPageManager.GetAll();
            return View(model);
        }
        public ActionResult Topics()
        {
            List<Topic> model = topicManager.GetAll();
            return View(model);
        }
        public ActionResult Commite()
        {
            List<Scientific> model = scientificManager.GetAll();
            ViewBag.speaker = model;
            List<OrganisingSpeaker> models = organisingManager.GetAll();
            ViewBag.organising = models;
            return View();
        }
        public ActionResult Invited_Speakers()
        {
            List<InvitedSpeaker> model = invitedSpeakerManager.GetAll();
            return View(model);
        }
        public ActionResult Mision_Vision()
        {
            List<MisionVision> model = misionVisionManager.GetAll();
            return View(model);
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Registration registration)
        {
            if (ModelState.IsValid)
            {
                registrationManager.Add(registration);
                return RedirectToAction("Participants","Home");
            }
            return View();
               
        }
        public ActionResult Participants()
        {
            List<Registration> model = registrationManager.GetAll();
            return View(model);
        }
        public PartialViewResult Slider()
        {
            return PartialView();
        }
     
        public PartialViewResult Contact()
        {

            return PartialView();
        }
        public ActionResult Program()
        {
            List<Program> model = programManager.GetAll();
            return View(model);
        }
       public ActionResult Sponsor()
        {
            List<Sponsor> model = sponsorManager.GetAll();
            return View(model);
        }
     

    }
}
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
    public class ManagerPanelController : Controller
    {
        // GET: ManagerPanel
        TopicManager topicManager = new TopicManager(new EfTopicDal());
        public ActionResult Index()
        {
            List<Topic> model = topicManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Topic topic)
        {
            if (ModelState.IsValid)
            {
                topicManager.Add(topic);
                return RedirectToAction("Index");
            }
            return View();
           
        }

        public ActionResult Delete(Topic topic)
        {
            topicManager.Delete(topic);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(Topic topic)
        {
           var deger= topicManager.Get(topic.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(Topic topic)
        {
            topicManager.Update(topic);
            return RedirectToAction("Index");
        }
    }
}
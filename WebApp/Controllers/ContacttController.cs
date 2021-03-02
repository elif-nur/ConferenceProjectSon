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
    public class ContacttController : Controller
    {
        // GET: Contactt

        ContactManager contactManager = new ContactManager(new EfContactDal());
        public ActionResult Index()
        {
            List<Contact> model = contactManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            contactManager.Add(contact);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(Contact contact)
        {
            var deger = contactManager.Get(contact.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(Contact contact)
        {
            contactManager.Update(contact);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Contact contact)
        {
            contactManager.Delete(contact);
            return RedirectToAction("Index");
        }
    }
}
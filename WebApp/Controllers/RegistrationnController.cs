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
    public class RegistrationnController : Controller
    {
        // GET: Registrationn
        RegistrationManager registrationManager = new RegistrationManager(new EfRegistrationDal());

        public ActionResult Index()
        {
            List<Registration> model = registrationManager.GetAll();
            return View(model);
        }
        public ActionResult Delete(Registration registration)
        {
            registrationManager.Delete(registration);
            return RedirectToAction("Index");
        }
    }
}
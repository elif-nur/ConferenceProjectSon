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
    public class ProgramController : Controller
    {
        // GET: Program
        ProgramManager programManager = new ProgramManager(new EfProgramDal());
        public ActionResult Index()
        {
            List<Program> model = programManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Program program)
        {
            programManager.Add(program);
            return RedirectToAction("Index");
        }
        public ActionResult Bring(Program program)
        {
            var deger = programManager.Get(program.Id);
            return View("Bring", deger);
        }
        [HttpPost]
        public ActionResult Update(Program program)
        {
            programManager.Update(program);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Program program)
        {
            programManager.Delete(program);
            return RedirectToAction("Index");
        }
    }
}
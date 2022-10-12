using HumanResourceManagement.Models.Data;
using HumanResourceManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumanResourceManagement.Controllers
{
    public class HomeController : Controller
    {
        private HumanResourceDbContext db = new HumanResourceDbContext();

        private IPersonalInfoRepo personalInfoRepo = new PersonalInfoRepo();
        
        public ActionResult Index()
        {
            var catagories = db.PersonalInformations.ToList();
            return View(catagories);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(PersonalInformation person)
        {
            if (!ModelState.IsValid)
                return View("About");

            personalInfoRepo.Create_Personal(person);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(PersonalInformation person)
        {
            return View();
        }

    }
}
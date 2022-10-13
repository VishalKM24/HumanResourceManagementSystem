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
        private IPersonalInfoRepo personalInfoRepo = new PersonalInfoRepo();
        
        public ActionResult Index()
        {
            var catagories = personalInfoRepo.AllInfo();
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
        public ActionResult Edit(int id)
        {
            var categories = personalInfoRepo.getInfoById(id);
            return View(categories);
        }
        [HttpPost]
        public ActionResult Edit(PersonalInformation person)
        {
            if (!ModelState.IsValid)
                return View("About");

            personalInfoRepo.Update(person);
            TempData["Message"] = $"The data got update for {person.PersonalID} {person.firstName} {person.lastName}";
            return View();
        }

    }
}
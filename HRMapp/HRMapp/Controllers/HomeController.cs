using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRMapp.ViewModels;
using HRMapp.Logic;

namespace HRMapp.Controllers
{
    public class HomeController : Controller
    {
        private SkillsetLogic skillsetLogic = new SkillsetLogic();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Skillset()
        {
            return View();
        }

        public IActionResult EditSkillset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditSkillset(SkillsetViewModel model)
        {
            var success = skillsetLogic.Add(new HRM.Models.Skillset(0, model.Title, model.Description));
            var skillsets = skillsetLogic.GetAll();
            return RedirectToAction("EditSkillset");
        }

        public IActionResult Task()
        {
            return View();
        }
    }
}

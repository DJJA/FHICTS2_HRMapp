using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRMapp.ViewModels;
using HRMapp.Logic;
using Microsoft.AspNetCore.Mvc.Rendering;
using HRM.Models;

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

        //public IActionResult Skillset()
        //{
        //    var skillsets = skillsetLogic.GetAll();

        //    var model = new SkillsetCollectionViewModel(skillsets.ToList(), skillsets.Count()-1);
        //    return View(model);
        //}

        public IActionResult Skillset(int id)
        {
            var skillsets = skillsetLogic.GetAll().ToList();

            int index = -1;
            for (int i = 0; i < skillsets.Count(); i++)
            {
                if (skillsets[i].Id == id) index = i;
            }

            var model = new SkillsetCollectionViewModel(skillsets.ToList(), index);
            return View(model);
        }

        //public IActionResult DisplaySkillset(int id)
        //{
        //    Skillset skillset = null;
        //    foreach (var skill in skillsetLogic.GetAll())
        //    {
        //        if (skill.Id == id)
        //            skillset = skill;
        //    }
        //    return PartialView("DisplaySkillsetPView", skillset);
        //}

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

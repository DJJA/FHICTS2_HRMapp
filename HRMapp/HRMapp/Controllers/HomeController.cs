using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRMapp.ViewModels;
using HRMapp.Logic;
using Microsoft.AspNetCore.Mvc.Rendering;
using HRMapp.Models;

namespace HRMapp.Controllers
{
    public class HomeController : Controller
    {
        private SkillsetLogic skillsetLogic = new SkillsetLogic();
        private TaskLogic taskLogic = new TaskLogic();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        #region Skillset
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

        public IActionResult NewSkillset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewSkillset(SkillsetViewModel model)
        {
            var idAddedSkillset = skillsetLogic.Add(new Skillset(model.Title, model.Description));
            return RedirectToAction("Skillset", new { id = idAddedSkillset });
        }

        public IActionResult EditSkillset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditSkillset(SkillsetViewModel model)
        {
            var idAddedSkillset = skillsetLogic.Add(new HRMapp.Models.Skillset(-1, model.Title, model.Description));
            //var skillsets = skillsetLogic.GetAll();
            return RedirectToAction("Skillset", new { id = idAddedSkillset });
        }
        #endregion
        #region Task
        public IActionResult Task(int id)
        {
            var tasks = taskLogic.GetAll();
            //var listItems = new List<SelectListItem>();
            //foreach (var task in tasks)
            //{
            //    listItems.Add(new SelectListItem() { Text = task.Name, Value = task.Id.ToString() });
            //}
            //return View(listItems);
            var model = new TaskCollectionViewModel(id, tasks.ToList());    // Where do I use a List and where an IEnumerable? Where do I convert?
            return View(model);
        }

        public IActionResult TaskView(int id)
        {
            var task = taskLogic.GetById(id);
            return PartialView("../Partial/_TaskView", task);
        }

        public IActionResult NewTask()
        {
            return View("../Shared/TaskEditor", new TaskEditorViewModel());
        }

        [HttpPost]
        public IActionResult NewTask(TaskEditorViewModel model)
        {
            //var addedTaskId = taskLogic.Add(new ProductionTask(-1, model.Title, model.Description));
            var addedTaskId = taskLogic.Add(model.ToTask());
            return RedirectToAction("Task", new { id = addedTaskId });
        }

        public IActionResult EditTask(int id)
        {
            var task = taskLogic.GetById(id);
            return View("../Shared/TaskEditor", new TaskEditorViewModel(task));
        }

        [HttpPost]
        public IActionResult EditTask(TaskEditorViewModel model)
        {
            var success = taskLogic.Update(model.ToTask());
            return RedirectToAction("Task", new { id = model.Id });
        }
        #endregion
    }
}

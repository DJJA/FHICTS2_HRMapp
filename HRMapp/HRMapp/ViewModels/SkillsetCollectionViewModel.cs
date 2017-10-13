using HRM.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMapp.ViewModels
{
    public class SkillsetCollectionViewModel
    {
        private List<Skillset> skillsets;
        public List<SelectListItem> SkillsetListItems { get; private set; }
        public List<Skillset> Skillsets
        {
            get { return skillsets; }
            set
            {
                skillsets = value;
                var listItems = new List<SelectListItem>();
                foreach (var skillset in skillsets)
                {
                    listItems.Add(new SelectListItem() { Text = skillset.Name, Value = skillset.Id.ToString(), Selected = (Skillsets[SelectedIndex].Id == skillset.Id) });
                }
                SkillsetListItems = listItems;
            }
        }
        public int SelectedIndex { get; private set; }

        public SkillsetCollectionViewModel(List<Skillset> skillsets, int index)
        {
            SelectedIndex = index;
            Skillsets = skillsets;
        }
    }
}

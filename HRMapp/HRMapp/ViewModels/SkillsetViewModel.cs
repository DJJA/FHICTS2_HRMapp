using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HRMapp.ViewModels
{
    public class SkillsetViewModel
    {
        public int Id { get; set; }
        [DisplayName("Titel:")]
        public string Title { get; set; }
        [DisplayName("Omschrijving:")]
        public string Description { get; set; }
    }
}

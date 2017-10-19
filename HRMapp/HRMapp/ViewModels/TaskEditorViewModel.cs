using HRMapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HRMapp.ViewModels
{
    public class TaskEditorViewModel
    {
        public string FormAction { get; private set; }
        public int Id { get; set; }
        [DisplayName("Titel:")]
        public string Title { get; set; }
        [DisplayName("Omschrijving:")]
        public string Description { get; set; }
        [DisplayName("Aantal uren:")]
        public int DurationHours { get; set; }
        [DisplayName("Aantal minuten:")]
        public int DurationMinutes { get; set; }    // Afvangen minimale en maximale minuten

        public TimeSpan Duration
        {
            get
            {
                return new TimeSpan(DurationHours, DurationMinutes, 0);
            }
            private set
            {
                DurationHours = value.Hours;
                DurationMinutes = value.Minutes;
            }
        }

        //public TaskEditorViewModel(bool addNewItem)
        //{
        //    FormAction = addNewItem ? "/Home/NewTask" : "/Home/EditTask";
        //}

        public TaskEditorViewModel()
        {
            FormAction = "NewTask";
        }

        //public TaskEditorViewModel(int id, string title, string description)
        //{
        //    FormAction = "EditTask";
        //    Id = id;
        //    Title = title;
        //    Description = description;
        //}

        public TaskEditorViewModel(ProductionTask task)
        {
            FormAction = "EditTask";
            Id = task.Id;
            Title = task.Name;
            Description = task.Description;
            Duration = task.Duration;
        }

        public ProductionTask ToTask()
        {
            return new ProductionTask(Id, Title, Description, Duration);
        }
    }
}

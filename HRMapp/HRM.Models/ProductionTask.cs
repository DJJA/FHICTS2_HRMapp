using System;
using System.Collections.Generic;
using System.Text;

namespace HRMapp.Models
{
    public class ProductionTask
    {
        private string name;
        public int Id { get; private set; }
        public string Name
        {
            get { return name; }
            private set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Task name must be set.");
                }
            }
        }
        public string Description { get; private set; }
        public TimeSpan Duration { get; private set; }
        public List<Skillset> RequiredSkillsets { get; private set; }

        public ProductionTask(int id, string name)
        {
            RequiredSkillsets = new List<Skillset>();
            Id = id;
            Name = name;
        }

        public ProductionTask(int id, string name, string description)
            : this(id, name)
        {
            Description = description;
        }

        public ProductionTask(int id, string name, string description, TimeSpan duration, List<Skillset> requiredSkillsets)
            : this(id, name, description)
        {
            Duration = duration;
            RequiredSkillsets = requiredSkillsets;
        }
    }
}

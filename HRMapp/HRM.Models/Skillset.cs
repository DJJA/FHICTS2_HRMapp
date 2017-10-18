using System;

namespace HRMapp.Models
{
    public class Skillset
    {
        private string name;
        public int Id { get; private set; }
        public string Name
        {
            get { return name; }
            private set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Skillset name must be set.");
                }
            }
        }
        public string Description { get; private set; }

        public Skillset(string name)
        {
            Id = -1;
            Name = name;
        }

        public Skillset(string name, string description)
            : this(name)
        {
            Description = description;
        }

        public Skillset(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Skillset(int id, string name, string description)
            : this(id, name)
        {
            Description = description;
        }
    }
}

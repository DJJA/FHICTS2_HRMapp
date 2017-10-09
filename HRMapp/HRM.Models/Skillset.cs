using System;

namespace HRM.Models
{
    public class Skillset
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Skillset(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

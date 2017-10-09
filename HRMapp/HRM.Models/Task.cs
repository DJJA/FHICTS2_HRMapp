using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Models
{
    public class Task
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public TimeSpan Duration { get; private set; }

        public Task(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

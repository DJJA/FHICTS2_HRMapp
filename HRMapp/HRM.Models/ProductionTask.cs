using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Models
{
    public class ProductionTask
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public TimeSpan Duration { get; private set; }

        public ProductionTask(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

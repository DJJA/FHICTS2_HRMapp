using System;
using System.Collections.Generic;
using System.Text;
using HRM.Models;
using System.Linq;

namespace HRMapp.DAL
{
    public class MemorySkillsetContext : ISkillsetContext
    {
        private static List<Skillset> list = new List<Skillset>();  // Static because the homecontroller gets reïnstatiated every request, so does the entire repository pattern

        public MemorySkillsetContext()
        {
            if (list.Count() == 0) AddRandomItems();
        }

        public int Add(Skillset value)
        {
            var skillset = new Skillset(list[list.Count - 1].Id + 1, value.Name, value.Description);
            list.Add(skillset);
            return skillset.Id;
        }

        public bool Delete(Skillset value)
        {
            list.Remove(value);
            return true;
        }

        public IEnumerable<Skillset> GetAll()
        {
            return list;
        }

        public Skillset GetById(int id)
        {
            return list.Single(skillset => skillset.Id == id);
        }

        public bool Update(Skillset value)
        {
            var item = list.Single(skillset => skillset.Id == value.Id);
            item = value;
            return true;
        }

        private void AddRandomItems()
        {
            list.Add(new Skillset(0, "Solderen 1"));
            list.Add(new Skillset(1, "Solderen 2"));
            list.Add(new Skillset(2, "Solderen 3"));
            list.Add(new Skillset(3, "Solderen 4"));
            list.Add(new Skillset(4, "Solderen 5"));
        }
    }
}

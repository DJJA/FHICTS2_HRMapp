using HRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMapp.DAL.Repositories
{
    public class SkillsetRepo : IRepo
    {
        private ISkillsetContext context = new MemorySkillsetContext();

        public IEnumerable<Skillset> GetAll() => context.GetAll();

        public bool Add(Skillset skillset)
        {
            context.Add(skillset);
            return true;
        }
    }
}

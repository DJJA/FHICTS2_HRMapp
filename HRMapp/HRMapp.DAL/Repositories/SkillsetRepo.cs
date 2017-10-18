using HRMapp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMapp.DAL.Repositories
{
    public class SkillsetRepo : IRepo
    {
        private ISkillsetContext context = new MemorySkillsetContext();

        public IEnumerable<Skillset> GetAll() => context.GetAll();

        public int Add(Skillset skillset)
        {
            return context.Add(skillset);
        }
    }
}

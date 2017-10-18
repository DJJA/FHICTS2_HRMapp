using HRMapp.Models;
using HRMapp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMapp.Logic
{
    public class SkillsetLogic
    {
        //private IRepo repo = new SkillsetRepo();
        private SkillsetRepo repo = new SkillsetRepo();

        public IEnumerable<Skillset> GetAll() => repo.GetAll();

        public int Add(Skillset s) => repo.Add(s);
    }
}

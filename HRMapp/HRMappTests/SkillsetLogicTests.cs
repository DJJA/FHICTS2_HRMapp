using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRMapp.Logic;
using HRM.Models;
using System.Collections;
using System.Linq;

namespace HRMappTests
{
    [TestClass]
    public class SkillsetLogicTests
    {
        [TestMethod]
        public void AddTest()
        {
            // Vars
            var logic = new SkillsetLogic();
            var skillsets = logic.GetAll();
            var newSkillset = new Skillset(99, "new skillset");

            // Operation
            logic.Add(newSkillset);

            // Test
            var skillsets2 = logic.GetAll();
            Assert.IsTrue(skillsets2.Contains(newSkillset));
        }
    }
}

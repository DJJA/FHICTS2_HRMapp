using HRMapp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMapp.DAL.Repositories
{
    public class TaskRepo : IRepo
    {
        private ITaskContext context = new MemoryTaskContext();

        public IEnumerable<ProductionTask> GetAll() => context.GetAll();
    }
}

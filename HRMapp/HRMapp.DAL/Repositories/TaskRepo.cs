﻿using HRMapp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMapp.DAL.Repositories
{
    public class TaskRepo : IRepo
    {
        private ITaskContext context = new MemoryTaskContext();

        public IEnumerable<ProductionTask> GetAll() => context.GetAll();
        public ProductionTask GetById(int id) => context.GetById(id);
        public int Add(ProductionTask task) => context.Add(task);
        public bool Update(ProductionTask task) => context.Update(task);
    }
}

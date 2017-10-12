﻿using System;
using System.Collections.Generic;
using System.Text;
using HRM.Models;
using System.Linq;

namespace HRMapp.DAL
{
    public class MemoryTaskContext : ITaskContext
    {
        private List<ProductionTask> list = new List<ProductionTask>();

        public MemoryTaskContext()
        {
            list.Add(new ProductionTask(0, "Connector solderen 1"));
            list.Add(new ProductionTask(1, "Connector solderen 2"));
            list.Add(new ProductionTask(2, "Connector solderen 3"));
            list.Add(new ProductionTask(3, "Connector solderen 4"));
            list.Add(new ProductionTask(4, "Connector solderen 5"));
        }
        public bool Add(ProductionTask value)
        {
            list.Add(value);
            return true;
        }

        public bool Delete(ProductionTask value)
        {
            list.Remove(value);
            return true;
        }

        public IEnumerable<ProductionTask> GetAll()
        {
            return list;
        }

        public ProductionTask GetById(int id)
        {
            return list.Single(task => task.Id == id);
        }

        public bool Update(ProductionTask value)
        {
            var item = list.Single(task => task.Id == value.Id);
            item = value;
            return true;
        }
    }
}
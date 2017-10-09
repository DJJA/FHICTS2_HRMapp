using System;
using System.Collections.Generic;
using System.Text;
using HRM.Models;
using System.Linq;

namespace HRMapp.DAL
{
    public class MemoryTaskContext : ITaskContext
    {
        private List<Task> list = new List<Task>();

        public MemoryTaskContext()
        {
            list.Add(new Task(0, "Connector solderen 1"));
            list.Add(new Task(1, "Connector solderen 2"));
            list.Add(new Task(2, "Connector solderen 3"));
            list.Add(new Task(3, "Connector solderen 4"));
            list.Add(new Task(4, "Connector solderen 5"));
        }
        public bool Add(Task value)
        {
            list.Add(value);
            return true;
        }

        public bool Delete(Task value)
        {
            list.Remove(value);
            return true;
        }

        public IEnumerable<Task> GetAll()
        {
            return list;
        }

        public Task GetById(int id)
        {
            return list.Single(task => task.Id == id);
        }

        public bool Update(Task value)
        {
            var item = list.Single(task => task.Id == value.Id);
            item = value;
            return true;
        }
    }
}

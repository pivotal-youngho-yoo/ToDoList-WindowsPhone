using System;
using System.Collections.Generic;
using System.Text;

namespace WindowPhoneBootcamp.Models
{
    class ToDoItem
    {
        private string task;
        private bool completed;

        public ToDoItem(string task, bool completed)
        {
            this.task = task;
            this.completed = completed;
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        public string Task
        {
            get { return task; }
            set { task = value; }
        }
    }
}

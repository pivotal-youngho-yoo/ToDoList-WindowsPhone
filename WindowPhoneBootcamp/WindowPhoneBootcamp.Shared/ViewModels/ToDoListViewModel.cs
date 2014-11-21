using System;
using System.Collections.Generic;
using System.Text;
using WindowPhoneBootcamp.Models;

namespace WindowPhoneBootcamp.ViewModels
{
    class ToDoListViewModel
    {
        private List<ToDoItem> toDoList;

        public ToDoListViewModel()
        {
            this.toDoList = new List<ToDoItem>();
        }

        public void AddToDoItem(string task)
        {
            ToDoItem newTask = new ToDoItem(task, false);
            toDoList.Add(newTask);
        }

        public List<ToDoItem> ToDoList
        {
            get { return toDoList; }
        }
    }
}

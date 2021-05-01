using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoClass
    {
        string whattodo;
        string description;
        string priority;
        int date;

        public ToDoClass(string whattodo, string description, string priority, int date)
        {
            this.whattodo = whattodo;
            this.description = description;
            this.priority = priority;
            this.date = date;
        }

        public string Whattodo { get => whattodo; set => whattodo = value; }
        public string Description { get => description; set => description = value; }
        public string Priority { get => priority; set => priority = value; }
        public int Date { get => date; set => date = value; }
    }
}

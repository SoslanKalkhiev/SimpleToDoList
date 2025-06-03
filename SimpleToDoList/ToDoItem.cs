using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList
{
    internal class ToDoItem
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
        public ToDoItem()
        {
            Title = "";
            DueDate = DateTime.Today;
            IsDone = false;
        }
        public ToDoItem(string title, DateTime dueDate)
        {
            Title = title;
            DueDate = dueDate;
            IsDone = false;
        }
        public override string ToString()
        {
            if (!IsDone && DueDate < DateTime.Today)
            {
                return Title + " (Overdue)";
            }
            if (IsDone)
            {
                return "[Done] " + Title;
            }

            return $"{Title} ({DueDate:dd.MM.yyyy})";
        }
    }
}

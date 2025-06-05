using System;

namespace SimpleToDoList
{
    
    public class TaskItem
    {
        
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public TaskItem(string description)
        {
            Description = description;
            IsDone = false;
        }

        public TaskItem(string description, bool isDone)
        {
            Description = description;
            IsDone = isDone;
        }

        public override string ToString()
        { 
            return IsDone
                ? $"{Description} (Выполнено)"
                : Description;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace SimpleToDoList
{
    internal class ToDoStorage
    {
        private const string DefaultFileName = "tasks.json";
        public static List<ToDoItem> Load(string filePath = null)
        {
            if (filePath == null)
                filePath = DefaultFileName;

            try
            {
                if (!File.Exists(filePath))
                    return new List<ToDoItem>();

                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<ToDoItem>>(json)
                       ?? new List<ToDoItem>();
            }
            catch (Exception)
            {
    
                return new List<ToDoItem>();
            }
        }
        
        public static void Save(List<ToDoItem> todos, string filePath = null)
        {
            if (filePath == null)
                filePath = DefaultFileName;

            try
            {
                string json = JsonSerializer.Serialize(todos, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(filePath, json);
            }
            catch (Exception)
            {
              
            }
        }
    }
}

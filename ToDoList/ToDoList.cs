using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Controls;
using System.Windows;
namespace ToDoList
{
    public class TasksToDo
    { 
            public List<string> tasks = new List<string>();

            public void AddTask(string NyTask)
            {
                tasks.Add(NyTask);
            }

            public void RemoveTask(int index)
            {
                if (index >= 0 && index < tasks.Count)
                {
                 tasks.RemoveAt(index);
                }
            }

            public List<string> GetAllTask()
            {
                return tasks;
            }
    }
}
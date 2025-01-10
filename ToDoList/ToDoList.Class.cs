using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    //<summary>
    //Hanterar logiken för att lägga till, ta bort och 
    //</summary>

    class IthemInList
    {
    //    public string Ithem { get; set; }
    //    public bool IsChecked { get; set; }

    //    public IthemInList(string ithem, bool isChecked)
    //    {
    //        Ithem = ithem;
    //        IsChecked = isChecked;
    //    }

    //Public void CheckAsDone()
    //    {
    //        IsChecked = true;

    //    }
        public class ToDoList
        {
            private List<string> tasks = new List<string>();

            public void AddTask(string task)
            {
                tasks.Add(task);

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
}

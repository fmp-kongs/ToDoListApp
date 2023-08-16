using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFinal
{
    public class Taskitem
    {
        public string taskId;

        public string taskTitle 
        {
            get;set; 
        }

        public string taskDescription
        {
            get; set;
        }

        public string completionStatus
        {
            get; set;
        }

        public string isPrioritized
        {
            get; set;

        }
        public string dueDate
        {
            get; set;
        }

    }
}

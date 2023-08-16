using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFinal
{
    internal class addTaskItem
    {
        Taskitem task = new Taskitem();
        public string addTitle()
        {
            Console.WriteLine("Enter the details to add a task !!");
            Console.WriteLine("");
            Console.WriteLine("Title: ");
            task.taskTitle = Console.ReadLine();
            if (task.taskTitle == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Title field can not be empty!");
                Console.ResetColor();
                addTitle();
            }
            return task.taskTitle;
        }

        public string addDescription()
        {
            Console.WriteLine("Description: ");
            task.taskDescription = Console.ReadLine();
            if (task.taskDescription == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Description field can not be empty!");
                Console.ResetColor();
                addDescription();
            }
            return task.taskDescription;
        }

        public string addCompletionStatus()
        {
            Console.WriteLine(" Completion Status : (yes/no)");
            task.completionStatus = Console.ReadLine();
            task.completionStatus = task.completionStatus.ToLower();
            if (task.completionStatus == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Completion status field can not be empty!");
                Console.ResetColor();
                addCompletionStatus();
            }
            else if (task.completionStatus == "yes")
            {
                task.completionStatus = "Yes";
            }
            else if (task.completionStatus == "no")
            {
                task.completionStatus = "No";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrect Entry for completion status");
                Console.ResetColor();
                addCompletionStatus();
            }
            return task.completionStatus;
        }

        public string addPriority()
        {
            Console.WriteLine("Task is prioritized: (yes/no)");
            task.isPrioritized = Console.ReadLine();
            task.isPrioritized = task.isPrioritized.ToLower();
            if (task.isPrioritized == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Priority field can not be empty!");
                Console.ResetColor();
                addPriority();
            }
            else if (task.isPrioritized == "yes")
            {
                task.isPrioritized = "Yes";
            }
            else if (task.isPrioritized == "no")
            {
                task.isPrioritized = "No";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrect Entry for completion status");
                Console.ResetColor();
                addPriority();
            }
            return task.isPrioritized;
            
        }

        public string addDueDate()
        {
            try
            {
                Console.WriteLine("Enter the due date :(dd/mm/yyyy)");
                var dueDate = Console.ReadLine();
                var date = DateTime.Parse(dueDate);
                if (date < DateTime.Now)
                {
                    Console.WriteLine("Due date can not be less than current date");
                    addDueDate();
                }
                else
                {
                    task.dueDate = dueDate;
                }
                
            }
            catch
            {
                Console.WriteLine("Error while due date input. Enter the due date in the specified format !!");

                addDueDate();

            }
            return task.dueDate;
        }





    }
}

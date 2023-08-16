using ConsoleTables;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFinal
{
    public class todoManager
    {
        List<Taskitem> todoListItems = new List<Taskitem>();

        //Generate Random No
        public string generateId()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max).ToString();   //returns random 4 digit integers 
        }
        Taskitem task = new Taskitem();

        // ******************************** Filtering Starts ********************************************************
        public void filterTask()
        {
            //
            List<Taskitem> todoListItemsTemp = new List<Taskitem>();
            todoListItemsTemp = todoListItems;

            Console.WriteLine("press 1 for filter isPrioritized column");
            Console.WriteLine("press 2 for filter completion status column");
            Console.WriteLine("press 3 for filter Id column");
            var filterid = Console.ReadLine();
            if (filterid != "1" && filterid != "2" && filterid != "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Wrong Entry. select correct option !"); Console.ResetColor();
                Console.WriteLine("");
            }
            else if (filterid == "1")
            {
                todoListItemsTemp = todoListItemsTemp.Where(x => x.isPrioritized == "Yes").ToList();

                var table = new ConsoleTable("taskId", "taskTitle", "Description", "completionStatus", "isPrioritized", "dueDate");
                for (int i = 0; i < todoListItemsTemp.Count; i++)
                {
                    table.AddRow(todoListItemsTemp[i].taskId, todoListItemsTemp[i].taskTitle, todoListItemsTemp[i].taskDescription, todoListItemsTemp[i].completionStatus, todoListItemsTemp[i].isPrioritized, todoListItemsTemp[i].dueDate);
                }

                table.Write();

            }
            else if (filterid == "2")
            {
                todoListItemsTemp = todoListItemsTemp.Where(x => x.completionStatus == "No").ToList();

                var table = new ConsoleTable("taskId", "taskTitle", "Description", "completionStatus", "isPrioritized", "dueDate");
                for (int i = 0; i < todoListItemsTemp.Count; i++)
                {
                    table.AddRow(todoListItemsTemp[i].taskId, todoListItemsTemp[i].taskTitle, todoListItemsTemp[i].taskDescription, todoListItemsTemp[i].completionStatus, todoListItemsTemp[i].isPrioritized, todoListItemsTemp[i].dueDate);
                }

                table.Write();

            }
            else if(filterid == "3")
            {
                Console.WriteLine("Enter the id of the task you are looking for !!");
                var id = Console.ReadLine();
                if (id == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ID can not be empty! try again");
                    Console.ResetColor();
                    Console.WriteLine("");

                }
                else
                {
                    todoListItemsTemp = todoListItemsTemp.Where(x => x.taskId == id).ToList();
                    if( todoListItemsTemp.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entered ID does not match any Task Ids ");
                        Console.ResetColor();
                        Console.WriteLine("");

                    }

                    var table = new ConsoleTable("taskId", "taskTitle", "Description", "completionStatus", "isPrioritized", "dueDate");
                    for (int i = 0; i < todoListItemsTemp.Count; i++)
                    {
                        table.AddRow(todoListItemsTemp[i].taskId, todoListItemsTemp[i].taskTitle, todoListItemsTemp[i].taskDescription, todoListItemsTemp[i].completionStatus, todoListItemsTemp[i].isPrioritized, todoListItemsTemp[i].dueDate);
                    }

                    table.Write();
                }
            }
        }
        // ******************************** Filtering Ends ********************************************************

        // ******************************** Sorting Starts *******************************************************

        public void sortTask()
        {
            //
            List<Taskitem> todoListItemsTemp = new List<Taskitem>();
            todoListItemsTemp = todoListItems;

            Console.WriteLine("press 1 for sorting due date column");
            Console.WriteLine("press 2 for sorting title column");
            Console.WriteLine("press 3 for sorting id column");
            var sortId = Console.ReadLine();
            if (sortId != "1" && sortId != "2" && sortId != "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Wrong Entry . select correct option !"); Console.ResetColor();
                Console.WriteLine("");
            }
            else if (sortId == "1")
            {

                todoListItemsTemp = todoListItemsTemp.OrderBy(x => DateTime.Parse(x.dueDate)).ToList();

                var table = new ConsoleTable("taskId", "taskTitle", "Description", "completionStatus", "isPrioritized", "dueDate");
                for (int i = 0; i < todoListItemsTemp.Count; i++)
                {
                    table.AddRow(todoListItemsTemp[i].taskId, todoListItemsTemp[i].taskTitle, todoListItemsTemp[i].taskDescription, todoListItemsTemp[i].completionStatus, todoListItemsTemp[i].isPrioritized, todoListItemsTemp[i].dueDate);
                }

                table.Write();

            }
            else if (sortId == "2")
            {
                todoListItemsTemp = todoListItemsTemp.OrderBy(x=>x.taskTitle).ToList();

                var table = new ConsoleTable("taskId", "taskTitle", "Description", "completionStatus", "isPrioritized", "dueDate");
                for (int i = 0; i < todoListItemsTemp.Count; i++)
                {
                    table.AddRow(todoListItemsTemp[i].taskId,todoListItemsTemp[i].taskTitle, todoListItemsTemp[i].taskDescription, todoListItemsTemp[i].completionStatus, todoListItemsTemp[i].isPrioritized, todoListItemsTemp[i].dueDate);
                }

                table.Write();


            }
            else if (sortId == "3")
            {
                todoListItemsTemp = todoListItemsTemp.OrderBy(x => x.taskId).ToList();

                var table = new ConsoleTable("taskId", "taskTitle", "Description", "completionStatus", "isPrioritized", "dueDate");
                for (int i = 0; i < todoListItemsTemp.Count; i++)
                {
                    table.AddRow(todoListItemsTemp[i].taskId, todoListItemsTemp[i].taskTitle, todoListItemsTemp[i].taskDescription, todoListItemsTemp[i].completionStatus, todoListItemsTemp[i].isPrioritized, todoListItemsTemp[i].dueDate);
                }

                table.Write();
            }

        }

        // ******************************** Sorting Ends *****************************************************************


        // **************************** Save to File Starts ****************************************************************
        public void saveTaskToFile()
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(todoListItems);
            string path = @"C:\Users\FakirMohanPatra\OneDrive - Kongsberg Digital AS\Desktop\Kongs_Training\dotNET\ToDoListApp\tasksFile3.json";
            using (var tw = new StreamWriter(path))
            {
                tw.WriteLine(JSONString.ToString());
                tw.Close();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved all the tasks to file");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // **************************** Save to File Ends ****************************************************************

        // **************************** Load from File Starts ****************************************************************

        public void loadTaskFromFile()
        {
            string json = File.ReadAllText(@"C:\Users\FakirMohanPatra\OneDrive - Kongsberg Digital AS\Desktop\Kongs_Training\dotNET\ToDoListApp\tasksFile3.json");

            List<Taskitem> todolist1 = (List<Taskitem>)JsonConvert.DeserializeObject(json, (typeof(List<Taskitem>)));
            var rows = todolist1.Count;

            todoListItems = todolist1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Here are tasks loaded from the file !!");
            Console.ResetColor();
            Console.WriteLine("");


            var table = new ConsoleTable("taskId", "taskTitle", "Description", "completionStatus", "isPrioritized", "dueDate");

            for (int i = 0; i < rows; i++)
            {

                table.AddRow(todolist1[i].taskId, todolist1[i].taskTitle, todolist1[i].taskDescription, todolist1[i].completionStatus, todolist1[i].isPrioritized, todolist1[i].dueDate);
            }

            table.Write();
        }

        // **************************************************** Load from file Ends ****************************************************



        // **************************************************** Add Task Starts **************************************

        public void addTask()
        {
          
            addTaskItem AddTaskItem = new addTaskItem();
            var title = AddTaskItem.addTitle();
            var description = AddTaskItem.addDescription();
            var compStatus = AddTaskItem.addCompletionStatus();
            var priorStatus = AddTaskItem.addPriority();
            var duedate = AddTaskItem.addDueDate();

            var id = generateId();

            List<string> details = new List<string>();

            todoListItems.Add(new Taskitem {taskId = id, taskTitle = title, taskDescription = description,completionStatus = compStatus,isPrioritized = priorStatus,dueDate = duedate });

            Console.ForegroundColor = ConsoleColor.Green;  // green message for success
            Console.WriteLine("The task has been added!!");
            Console.ResetColor();
            Console.WriteLine("");


        }

        // **************************************************** Add Task Ends **************************************


        // **************************************************** View Task Starts **************************************

        public void viewTask()
        {
            
            var numTask = todoListItems.Count;
            if(numTask == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("There are no tasks! Hurry up, Add your first task");
                Console.ResetColor();
                Console.WriteLine("");
            }
            var table = new ConsoleTable("taskId", "taskTitle", "Description", "completionStatus", "isPrioritized", "dueDate");

            for (int i = 0; i < numTask; i++)
            {
                table.AddRow(todoListItems[i].taskId,todoListItems[i].taskTitle, todoListItems[i].taskDescription, todoListItems[i].completionStatus, todoListItems[i].isPrioritized, todoListItems[i].dueDate);
            }

            table.Write();

        }

        // **************************************************** View Task Ends **************************************

        // **************************************************** Remove Task Starts **************************************

        public void removeTask()
        {
            //

            Console.WriteLine("Enter the id of the task to be removed!!");
            var id  = Console.ReadLine();
            id = id.ToString();
            var flag = 0;
            for (int i = 0;i < todoListItems.Count; i++)
            {
                if (todoListItems[i].taskId == id)
                {
                    todoListItems.RemoveAt(i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The task has been removed!!");
                    Console.ResetColor();
                    Console.WriteLine("");

                    flag += 1;
                }
            }
            if (flag == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("entered id does exist, try entering id again!!");
                Console.ResetColor();
                Console.WriteLine("");

            }


        }

        // **************************************************** Remove Task Ends **************************************


        // **************************************************** Modify Task Starts **************************************


        public void modifyTask()
        {
            Console.WriteLine("Enter the id of the task to be modified!!");
            var id = Console.ReadLine();
            id = id.ToString();
            var flag = 0;
            for (int i = 0; i < todoListItems.Count; i++)
            {
                if (todoListItems[i].taskId == id)
                {
                    Console.WriteLine("Enter 1 to edit title: ");
                    Console.WriteLine(" 2 - Edit description");
                    Console.WriteLine(" 3 - edit Completion status");
                    Console.WriteLine(" 4 - edit priority");
                    Console.WriteLine(" 5 - edit dueDate");
                    Console.WriteLine("");
                    var editId = Console.ReadLine();

                    if (editId != "1" && editId != "2" && editId != "3" && editId != "4" && editId != "5")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Entered option is not valid, try again");
                        Console.ResetColor ();
                        Console.WriteLine("");

                        modifyTask();

                    }
                    else if (editId == "1")
                    {
                        Console.WriteLine("Enter the new title for the task: ");
                        todoListItems[i].taskTitle = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The task has been modified!");
                        Console.ResetColor ();
                        Console.WriteLine("");

                    }
                    else if (editId == "2")
                    {
                        Console.WriteLine("Enter the new description for the task: ");
                        todoListItems[i].taskDescription = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The task has been modified!");
                        Console.ResetColor ();
                        Console.WriteLine("");

                    }
                    else if (editId == "3")
                    {
                        Console.WriteLine("Enter the completion status for the task: ");
                        todoListItems[i].completionStatus = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The task has been modified!");
                        Console.ResetColor ();
                        Console.WriteLine("");

                    }
                    else if (editId == "4")
                    {
                        Console.WriteLine("Enter the priority for the task: ");
                        todoListItems[i].isPrioritized = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The task has been modified!");
                        Console.ResetColor ();
                        Console.WriteLine("");

                    }
                    else if (editId == "5")
                    {
                        Console.WriteLine("Enter the new due date for the task: ");
                        todoListItems[i].dueDate = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The task has been modified!");
                        Console.ResetColor ();
                        Console.WriteLine("");

                    }


                    flag += 1;
                }
            }
            if (flag == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("entered id does exist, try entering id again!!");
                Console.ResetColor ();
                Console.WriteLine("");
            }

            // **************************************************** Modify Task Ends **************************************

        }

    }
}

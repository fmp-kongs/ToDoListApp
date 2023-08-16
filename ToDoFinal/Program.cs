using ConsoleTables;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ToDoFinal
{
  
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to ToDo-List App!");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");

            var todomanager = new todoManager();

            while (true)
            {
                Console.WriteLine("Here are the options you can select : ");
                Console.WriteLine(" 0 - Exit");
                Console.WriteLine(" 1 - View Tasks");
                Console.WriteLine(" 2 - Add Tasks");
                Console.WriteLine(" 3 - Remove Tasks");
                Console.WriteLine(" 4 - Modify Tasks");
                Console.WriteLine(" 5 - Save Tasks to a file! ");
                Console.WriteLine(" 6 - Load Tasks from a file!");
                Console.WriteLine(" 7 - for sorting operations");
                Console.WriteLine(" 8 - for filtering operations");
                Console.WriteLine("");


                string userInput = Console.ReadLine();
                bool optionParseResult = int.TryParse(userInput, out int optionId);

                if (!optionParseResult)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input was not an Integer. Choose from the below options !!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    continue;
                }

                if (optionId == 0)
                {
                    break;
                }

                if (optionId == 1)
                {
                    todomanager.viewTask();               
                }

                else if (optionId == 2)
                {
                    todomanager.addTask();
                }

                else if (optionId == 3)
                {
                    todomanager.removeTask();
                }

                else if(optionId == 4)
                {
                    todomanager.modifyTask();
                }
                else if(optionId == 5)
                {
                    todomanager.saveTaskToFile();
                }
                else if (optionId == 6)
                {
                    todomanager.loadTaskFromFile();
                }
                else if (optionId == 7)
                {
                    todomanager.sortTask();
                }
                else if (optionId == 8)
                {
                    todomanager.filterTask();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Choose from the below options!!");
                    Console.ResetColor();
                    Console.WriteLine("");
                }

            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Thanks for using TODO list. Hoping to see you soon !!!!!!!!!!!!!!!!!");
            Console.ResetColor();
        }
    }
}
    

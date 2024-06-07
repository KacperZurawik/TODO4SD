using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO4SD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TODO4SD 1.0");
            Console.WriteLine("Fast TODO list for Service Desk");
            Console.WriteLine("Current date: " + DateTime.Now);
            Console.WriteLine();



            //menu switchase

            Console.WriteLine("1. Create new task");
            Console.WriteLine("2. Show in progress tasks");
            Console.WriteLine("3. Show tasks that have been done");

            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.Write("Write down your first task here: ");
                    var userTodo = Console.ReadLine();
                    Console.WriteLine(userTodo);
                    break;
                case "2":
                    Console.WriteLine("b");
                    break;
                case "3":
                    Console.WriteLine("c");
                    break;
                default:
                    break;
            }

            Console.ReadLine();

         

            //zrobic menu z pogladatem taskow
            // w menu opcja utworzenia nowego taska
            // taski maja zapisywac siew notatniku

        }
    }
}

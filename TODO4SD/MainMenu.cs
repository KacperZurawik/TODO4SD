using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO4SD
{
    internal class MainMenu
    {

        private static bool DisplayMenu()
        {
            Console.WriteLine("What you want to do?");
            Console.WriteLine("1. Write down a task");
            Console.WriteLine("2. Mark task as done");
            Console.WriteLine("3. Show all tasks");
            Console.WriteLine("4. Delete task");
            Console.Write("\r\nPut the number (1-4): ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    return true;
                case "2":
                    Console.WriteLine();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }

            Console.ReadLine();

        }
    }
}

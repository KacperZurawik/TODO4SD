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
            Console.WriteLine("TODO4SD");
            Console.WriteLine("Fast TODO list for Service Desk");
            Console.WriteLine("Current date: " + DateTime.Now);
            Console.WriteLine();

            Console.Write("Write your first task here: ");
            var userTodo = Console.ReadLine();
            Console.WriteLine(userTodo);

            //menu switchase
            string switchc = "switchc";
            switch (switchc)
            {
                case "a":
                    Console.WriteLine("x");
                    break;
                case "b":
                    Console.WriteLine("b");
                    break;
                case "c":
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO4SD
{
    internal class Menu
    {

        private void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("TODO4SD");
                Console.WriteLine("Main menu");
                Console.WriteLine();

                Console.WriteLine("1. Write down a new task");
                Console.WriteLine("2. Show all tasks");
                Console.WriteLine("3. Delete a task");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine();
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine();
                            break;
                        }



                }
            }

        }
    }
}

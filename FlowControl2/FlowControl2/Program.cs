using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl2
{
    class Program
    {
        static void Main(string[] args)
        {

            // added background color to our console.
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            MainMenu();
        }

        public static void MainMenu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {

                Console.Clear();
                Console.WriteLine("This is the main menu");
                Console.WriteLine("Input a number to choose a funcion");
                Console.WriteLine("0) Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        keepGoing = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\nTry again ");
                        Console.ReadKey();
                        break;
                }
            }
        }

     

    }
}

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
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat ten times");
                Console.WriteLine("0) Exit");

                string input = Console.ReadLine();

                switch (input) // Switch-case belongs to while
                {
                    case "1":
                        AdolescentOrSenior();
                        break;
                    case "2":
                        RepeatTenTimes();
                        break;
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

        public static void AdolescentOrSenior()
        {
            Console.WriteLine("What is your age?: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            if (age < 20)
            {
                Console.WriteLine("Kids deal : 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior Citizen Discount : 90kr");
            }
            else
            {
                Console.WriteLine("Standard Price : 120kr");
            }
            Console.ReadLine();
        }

        public static void RepeatTenTimes()
        {
            Console.Clear();
            Console.WriteLine("What do you want to repeat 10x ?:");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + " . " + input + ", ");
            }
            Console.ReadLine();
        }



    }
}

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
            MainMenu();
        }

        public static void MainMenu ()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("This is the main menu.");
                Console.WriteLine("Input number to choose function");
                Console.WriteLine("0) Exit");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat ten times");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        keepGoing = false;
                        break;
                    case "1":
                        AdolescentOrSenior();
                        break;
                    case "2":
                        RepeatTenTime();
                        break;
                    default:
                        Console.WriteLine("Incorrect choice \nPlease input again");
                        Console.ReadKey();
                        break;
                }

            }
        }

        public static void AdolescentOrSenior()
        {
            Console.Clear();
            Console.Write("What is your age:");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            if (age < 20)
            {
                Console.WriteLine("Kid deals: 80kr");
            }
            else if(age > 64)
            {
                Console.WriteLine("Senior Citizen Discount: 90kr");
            }
            else
            {
                Console.WriteLine("Standard Price: 120kr");
            }
            Console.ReadKey();
        }

        public static void RepeatTenTime()
        {
            Console.Clear();
            Console.Write("What do you want to repeat:");
            string input = Console.ReadLine();
            for (int i=0; i<10; i++)
            {
                Console.Write((i + 1)+ ". " + input + ", ");
            }
            Console.ReadKey();
        }
    }
}

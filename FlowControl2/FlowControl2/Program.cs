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
        public static void MainMenu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("This is the main menu.");
                Console.WriteLine(" Input a number to chooce function");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat");
                Console.WriteLine("0) Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        AdolescentOrSenior();
                        break;
                    case "0":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\nTry again!");
                        Console.ReadKey();
                        break;
                }
            }

        }
        public static void AdolescentOrSenior()
        {
            Console.Write("What is your age?: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            if (age<20)
            {
                Console.WriteLine("Kid Deals: 80 Kr");
            }
            else if (age>64)
            {
                Console.WriteLine("Senior Citizen Discount: 90Kr");
            }
            else
            {
                Console.WriteLine("Standard Price: 120Kr");
            }
            Console.ReadLine();
        }
        public static void RepeatTenTimes()
        {
            Console.WriteLine("What do you want to repeat? ");
            string input = Console.ReadLine();
            for (int i= 0; i< 10; i++)
            {
                Console.Write((i+1)+"."+input+", ");
            }
            Console.ReadLine();
        }
    }
}

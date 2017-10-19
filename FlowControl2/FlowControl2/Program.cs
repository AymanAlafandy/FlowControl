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
            bool keepgoing = true;
            while (keepgoing)
            {
                Console.Clear();
                Console.WriteLine("This is the main menu");
                Console.WriteLine("Input a number to choose function");
                Console.WriteLine("(1)-> Cinema");
                Console.WriteLine("(2)-> Repeat the word");
                Console.WriteLine("(0)-> exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AdolescentORSenior();
                        break;
                    case "2":
                        RepeatTentimes();
                        break;
                    case "0":
                        keepgoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input,please give the correct input");
                        break;
                }
            }
        }
        public static void AdolescentORSenior()
        {
            Console.WriteLine("Tell us your age: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            if (age < 20)
            {
                Console.WriteLine("kids deal:80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior citizen Dicount:90kr");
            }
            else
            {
                Console.WriteLine("Standard Price:120kr");
            }
            Console.ReadLine();
        }
        public static void RepeatTentimes()
        {
            Console.Clear();
            Console.Write("what do you want to repeat:");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1)+"."+input+",");
            }
            Console.ReadLine();

        }
    }
}

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
                Console.WriteLine("(0)-> exit");
                string input = Console.ReadLine();
                switch (input)
                {
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

        }
    }
}

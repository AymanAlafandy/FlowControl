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
            bool KeepGoing = true;
            while (KeepGoing)
            {
                Console.WriteLine("this is the main menu.");
                Console.WriteLine("Input a number to choose function");
                Console.WriteLine("0) Exit");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        KeepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\nTry Again");
                        break;
                }
            }
        }
    }
}

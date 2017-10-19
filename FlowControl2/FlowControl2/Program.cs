using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl2
{
    class Program
    {
        //everything is writting in the mainMethod will be in the memory because it is static
        //so it is recommanded to keep it clean or write small code on it.
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            bool KeepGoing = true;
            while (KeepGoing)
            {
                Console.Clear();
                Console.WriteLine("This is the MainMenu.");
                Console.WriteLine("Input number to choose function.");
                Console.WriteLine("0) Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        KeepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\n Try Again \t If you want");
                        Console.ReadKey();
                        break;
                }

            }
        }

        public static void AdolescentOrSenior()
        {

        }
    }
}

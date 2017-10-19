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
                Console.clean();
                Console.WriteLine("this is the menu.");
                Console.WriteLine("input a num to chose function");
                Console.WriteLine("0)Exite");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        KeepGoing = false;
                        break;
                    default:
                        Console.WriteLine("incorrect input\ntry again");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AdolescentOrSenior()
        {

        }

        public static void MainMenu()
        {

        }
    }
}

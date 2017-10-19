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
            bool keepGoing = true;
            while (keepGoing)
              {
                Console.Clear();
                Console.WriteLine("This is the main menu.");
                Console.WriteLine("Input number to choose function");
                Console.WriteLine("0) Exit");
                string input = Console.ReadLine();
                                switch (input)
                                    {
                         case "1":
                        Adolescentorsenior();
                        break;
                   
                                     case "0":
                                     keepGoing = false;
                                     break;
                                     default:
                    Console.WriteLine("Incorrect choice \nPlease input again");
                    Console.ReadKey();
                                     break;
                                  }
                
           }
        }
        public static void Adolescentorsenior()
        {
            Console.Write("What is your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            if (age < 20)
            {
                Console.WriteLine("Kid Deal : 80 kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior citizen discount : 90 kr");
                            }
            else 
            {
                Console.WriteLine("Standar prise : 120kr");
            }
            Console.ReadLine();
        }
      
    }
}

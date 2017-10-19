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
                Console.WriteLine("1. Cinema");
                Console.WriteLine("2. Repeater");
                Console.WriteLine("3. Third word");
                Console.WriteLine("0) Exit");
                string input = Console.ReadLine();
                                switch (input)
                                    {
                                 case "1":
                        Adolescentorsenior();
                        break;
                                 case "2":
                        Repeattentimes();
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
            Console.Clear();
            Console.Write("What is your age : ");
            string input = Console.ReadLine();
            uint age = 0;
            bool correctAge = true;
            do
            {
                Console.Clear();
                if (!correctAge)
                {
                    Console.WriteLine("Please enter your correct age");
                }
                Console.WriteLine("what is your age:");
                input = Console.ReadLine();

                correctAge = uint.TryParse(input, out age);
            } while (!correctAge);
            

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

        public static void Repeattentimes()
        {
            Console.WriteLine("What do you want repeated");
            string input = Console.ReadLine();

            for (int i = 0; i <10; i++)
            {

                Console.Write((i + 1) + ". " + input + ",");

            }

            Console.ReadLine();
        }
        public static void Thirdword()
        {

            Console.WriteLine("Please input straing with atleast 3 words");
            string input = Console.ReadLine();
            string[] arrayofwords = input.Split(' ');
            if (arrayofwords.Length < 3)
            {
                Console.WriteLine("Please enter atleast 3 words");
            }
            else
            { 
            Console.WriteLine(arrayofwords[2]);
            }
            Console.ReadLine();




        }
        }
    }


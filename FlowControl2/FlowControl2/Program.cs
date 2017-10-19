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
                Console.Clear();
                Console.WriteLine("this is the menu.");
                Console.WriteLine("input a num to chose function");
                Console.WriteLine("3)ThirdWord ");
                Console.WriteLine("2)RepeatTenTimes");
                Console.WriteLine("1)cinema");
                Console.WriteLine("0)Exite");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AdolescentOrSenior();
                        break;
                    case "2":
                        RepeatTenTimes();
                        break;
                    case "3":
                        ThirdWord();
                        break;
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
            string input;
            uint age = 0;
            bool correctAge = true;
            do
            {
                Console.Clear();
                if (!correctAge)
                {
                    Console.WriteLine("please try again\n");
                }
                Console.Write("what is your age?:");
                input = Console.ReadLine();
                correctAge = uint.TryParse(input, out age);
            } while (!correctAge);

            if (age < 20)
            {
                Console.WriteLine("kid deal:80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("senior citizen discount:90kr");
            }
            else
            {
                Console.WriteLine("standard price:120kr");
            }
            Console.ReadLine();

        }

        public static void RepeatTenTimes()
        {
            Console.Clear();
            Console.WriteLine("what do you want to repeated:");
            string input;
            do
            {
                input = Console.ReadLine();
                if (input.Length > 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write((i + 1) + ". " + input + ", ");
                    }
                    Console.Write("10." + input);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("you must want to repeat something..\n");
                }
            } while (input.Length < 1);
            Console.ReadLine();
        }

        public static void ThirdWord()
        {
            Console.Clear();
            bool longEnough = true;
            do
            {

                Console.WriteLine("please enter a sentence with at least three words:");
                string input = Console.ReadLine();
                string[] arrayOfWords = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                longEnough = (arrayOfWords.Length > 2);

                if (longEnough)
                {
                    Console.Clear();
                    Console.WriteLine("The sentence shoud be atleast 3 words");
                }
                else
                {
                    Console.WriteLine(arrayOfWords[2]);
                }

                Console.ReadLine();
            } while (longEnough);
        }


    }
}
    


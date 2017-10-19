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
                Console.WriteLine("Input a number to chooce function");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat ten times");
                Console.WriteLine("3) Third Word");
                Console.WriteLine("0) Exit");
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
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\nTry Again");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AdolescentOrSenior()
        {
            string input;
            uint age = 0; // using uint to allow the int to even accept minus numbers


            bool correctAge = true;

            do
            {
                Console.Clear();
                if (!correctAge)
                {
                    Console.WriteLine("Please try again\n");
                }

                Console.Write("What is your age?: ");
                input = Console.ReadLine();
                correctAge = uint.TryParse(input, out age);

                if (age < 0 || age > 200)
                {
                    correctAge = false;
                }

            } while (!correctAge);



            if (age < 20)
            {
                Console.WriteLine("Kid deal: 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior Citizen Discount: 90kr");
            }
            else
            {
                Console.WriteLine("Standard Price: 120kr");
            }
            Console.ReadLine();
        }

        public static void RepeatTenTimes()
        {
            Console.Clear();
            string input;
            do
            {
                Console.Write("What do you want repeated?: ");
                input = Console.ReadLine().Trim();
                if (input.Length > 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write((i + 1) + ". " + input + ", ");
                    }
                    Console.Write("10. " + input);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must want to repeat something..\n");
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
                Console.WriteLine("Please enter a sentence with at least three words");
                string input = Console.ReadLine();

                string[] arrayOfWords = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                longEnough = (arrayOfWords.Length > 2);
                if (!longEnough)
                {
                    Console.Clear();
                    Console.WriteLine("The sentence needs to be at least three words long\n");
                }
                else
                {
                    Console.Write("The third word is: ");
                    Console.WriteLine(arrayOfWords[2]);
                }
                Console.ReadLine();
            } while (!longEnough);
        }
    }
}

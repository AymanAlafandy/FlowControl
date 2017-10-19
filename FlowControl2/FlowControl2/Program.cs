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

            // added background color to our console.
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            MainMenu();
        }

        public static void MainMenu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {

                Console.Clear();
                Console.WriteLine("This is the main menu");
                Console.WriteLine("Input a number to choose a funcion");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat ten times");
                Console.WriteLine("3) Third Word Finder");
                Console.WriteLine("0) Exit");

                string input = Console.ReadLine();

                switch (input) // Switch-case belongs to while
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
                        keepGoing = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\nTry again ");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AdolescentOrSenior()
        {



            int age = 0;
            Console.Write("Age:  ");

            // used While loop instead of Do-While loop
            while (!int.TryParse(Console.ReadLine(), out age))
            {

                Console.WriteLine("Oops! Wrong Age Please Try Again ");

                Console.Write("Age:  ");
            }




            if (age < 20)
            {
                Console.WriteLine("Kids deal : 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior Citizen Discount : 90kr");
            }
            else
            {
                Console.WriteLine("Standard Price : 120kr");
            }
            Console.ReadLine();
        }

        public static void RepeatTenTimes()
        {





            Console.WriteLine("");
            Console.WriteLine("What do you want to repeat 10x ?:");
            Console.WriteLine("");

            Console.Write("Text:  ");





            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + " . " + input + ", ");
            }
            Console.ReadLine();
        }

        public static void ThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Please enter a sentence with at least 3 words");
            string input = Console.ReadLine();

            string[] arrayOfWords = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            if (arrayOfWords.Length < 3)
            {
                Console.WriteLine("The sentence need to be at least three words long");
            }
            else
            {
                Console.WriteLine(arrayOfWords[2]);
            }
            Console.ReadLine();
        }


    }
}

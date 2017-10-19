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
            while(keepGoing)
            {
                Console.Clear();
                Console.WriteLine("this is the main menu.");
                Console.WriteLine("Input a number to chooce Function");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat 10 times");
                Console.WriteLine("3) Third Word");
                Console.WriteLine("0) Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AdolecentOrSenior();
                        break;
                    case "2":
                        Repeat();
                        break;
                    case "3":
                        ThirdWord();
                        break;
                    case "0":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\ntry again");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AdolecentOrSenior()
        {
            string input = Console.ReadLine();
            uint age = 0;
            bool correctAge = true;
            do
            {
                if(!correctAge)
                {
                    Console.WriteLine("Please try again");
                }
            Console.Clear();
            Console.Write("What is your age?: ");
            correctAge = uint.TryParse(input, out age)
            }
            while(!correctAge);

            if(age < 20)
            {
                Console.WriteLine("Kids Deal: 80kr");
            }
            else if(age > 64)
            {
                Console.WriteLine("Senior Citizen Discount: 90kr");
            }
            else
            {
                Console.WriteLine("Standard Prize: 120kr");
            }
            Console.ReadLine();
        }

        public static void Repeat()
        {
            Console.Clear();
            Console.Write("What do you want repeated?: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1) + ". " + input + ", ");
            }
            Console.ReadLine();
        }

        public static void ThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Please enter a sentance with at least 3 words");
            string input = Console.ReadLine();
            string[] arrayOfWords = input.Split(' ');
            if (arrayOfWords.Length < 3)
            {
                Console.WriteLine("the sentence need to be at least 3 words long");
            }
            else
            {
                Console.WriteLine(arrayOfWords[2]);
            }
            Console.ReadLine();
        }
    }
}

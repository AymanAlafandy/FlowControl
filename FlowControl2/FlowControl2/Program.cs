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
                Console.WriteLine("This is the main menu.");
                Console.WriteLine("Input a number to choose function");
                Console.WriteLine("0) Exit");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat a text ten times");
                Console.WriteLine("3) ThirdWord");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        KeepGoing = false;
                        break;
                    case "1":
                        AdolescentOrSenior();
                        break;
                    case "2":
                        RepeatTenTimes();
                        break;
                    case "3":
                        ThirdWord();
                        break;
                    default:
                        Console.WriteLine("Incorrect input\nTry Again");
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
                    Console.WriteLine("Please try again\n");
                }

                Console.Write("What is your age?:");
                input = Console.ReadLine();
                correctAge = uint.TryParse(input, out age);


            }
            while (!correctAge);
            {
                if (age < 20)
                {
                    Console.WriteLine("Kids Deal: 80kr");
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
        }
        public static void RepeatTenTimes()
        {
            Console.Clear();
            Console.WriteLine("What Do you want repeated?: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1)+". " + input + ",");
            }
            Console.ReadLine();
        }
        public static void ThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Please enter a sentence with at least three words");
            string input = Console.ReadLine();
            string[] arrayOfWords = input.Split(new char[' '], StringSplitOptions.RemoveEmptyEntries);
             bool longEnough = arrayOfWords.Length < 2;
            if (!longEnough)
            {
                Console.WriteLine("The sentence needs to be atleast three words");
            }
            else
            {
                Console.WriteLine(arrayOfWords[2]);
            }
            
            Console.ReadLine();
        }
    }
}

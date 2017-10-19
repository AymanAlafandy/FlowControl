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
            //Taleb has a good mustach
            //.trim() remove the whiteSpaces from the begining and the end but not between
        }

        public static void MainMenu()
        {
            bool KeepGoing = true;
            while (KeepGoing)
            {
                Console.Clear();
                Console.WriteLine("This is the MainMenu.");
                Console.WriteLine("Input number to choose function.");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) repeat ten times");
                Console.WriteLine("3) Write a sentence");
                Console.WriteLine("0) Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AdolescentOrSenior();
                        break;

                    case "2":
                        RepeatItTenTimes();
                        break;
                    case "3":
                        ThirdWord();
                        break;

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
            string input;
            uint age = 0; // the 0 is just a value nothing else you can put another number
            bool correctAge = true;

            do
            {
                if (!correctAge)
                {
                    Console.WriteLine("Please try again\n ");
                }
                Console.Clear();
                Console.Write("What is your age?: ");  //we use console.write to end upp at the same line to input..
                input = Console.ReadLine();
                correctAge = uint.TryParse(input, out age);

            }
            while (!correctAge); //TryParse is the best because har return type of bool true of fals (out)
            {
            if (age < 20)
            {                                           //uint unsind int is just positive numbers 
                Console.WriteLine("kid Deal: 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior Citizen: 90kr");
            }
            else
            {
                Console.WriteLine("Standar Prise: 120kr");
            }
            }
            Console.ReadLine();
        }
        public static void RepeatItTenTimes()
        {
            Console.Clear();
            Console.WriteLine("What do you want to repeated?: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 9; i++)
            {
                Console.Write((i +1 ) + "." + input+", ");
            }
            Console.ReadLine();
        }
        public static void ThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Please enter a sentence with at least three words. ");
            string input = Console.ReadLine();
            string[] arrayOfWords = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries); //It split the inside of the '' here we have a WhiteSpace
            if (arrayOfWords.Length > 2)  // efter split every word become a string by it self
            {
                Console.WriteLine("The sentence needs to be at leas three words");
            }
            else
            {
                Console.WriteLine(arrayOfWords[2]);
            }

            
            Console.ReadLine();
        }
    }
}

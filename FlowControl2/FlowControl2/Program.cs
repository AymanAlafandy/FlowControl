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
                Console.WriteLine("This is the main menu");
                Console.WriteLine("Input a number to choose function");
                Console.WriteLine("0) Exit");
                Console.WriteLine("1) Cinema");
                Console.WriteLine("2) Repeat Ten Times");
                Console.WriteLine("3) Third Word");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        keepGoing = false;
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
                    Console.WriteLine("Please try again\n");
                } 
                
                Console.WriteLine("What is your Age?:");
                input = Console.ReadLine();
                correctAge = uint.TryParse(input, out age);
                if(age<0 || age > 110)
                {
                    correctAge = false;
                }
            } while (!uint.TryParse(input, out age));
            // int.TryParse(input, out age);
            //int age = int.Parse(input);
            if (age < 20)
            {
                Console.WriteLine("Kids Deal:80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior Citizen Discount:90kr");
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
            Console.WriteLine("What do you want repeated?: ");
            string input;
            do
            {
                Console.WriteLine();
                input = Console.ReadLine().Trim();
                if (input.Length > 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + input + ", ");
                    }
                    Console.WriteLine("10. " + input);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must want to repeat something\n ");
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
                Console.WriteLine("Please enter a sentence with atleast three words");
                string input = Console.ReadLine();

                string[] arrayOfWords = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                longEnough = (arrayOfWords.Length > 2);
                if (!longEnough)
                {
                    Console.Clear();
                    Console.WriteLine("The sentence needs to be atleast three words long");
                }
                else
                {
                    Console.WriteLine("The third word is: ");
                    Console.WriteLine(arrayOfWords[2]);
                }
                Console.ReadLine();
            } while (!longEnough);

             

        }






    }

}

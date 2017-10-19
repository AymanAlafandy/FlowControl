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
            bool keepgoing = true;
            while (keepgoing)
            {
                Console.Clear();
                Console.WriteLine("This is the main menu");
                Console.WriteLine("Input a number to choose function");
                Console.WriteLine("(1)-> Cinema");
                Console.WriteLine("(2)-> Repeat the word");
                Console.WriteLine("(3)-> Split the word");
                Console.WriteLine("(0)-> exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AdolescentORSenior();
                        break;
                    case "2":
                        RepeatTentimes();
                        break;
                    case "3":
                        Thirdword();
                        break;
                    case "0":
                        keepgoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input,please give the correct input");
                        break;
                }
            }
        }
        public static void AdolescentORSenior()
        {

            string input;
            uint age = 0;
            bool correctage = true;
            do {
                Console.Clear();
                if (!correctage)
                {
                    Console.WriteLine("Please try again:\n");
                }
                
                Console.Write("Tell us your age: ");
                input =Console.ReadLine();
                correctage = uint.TryParse(input,out age);
                //unsigned int,it will display 0 if v give negative value
                //tryparse will hndle exception if some user gives string input fr ex-TEN
                if (age < 0 || age > 200)
                {
                    Console.WriteLine("Free for you");
                }
            } while (!correctage);
                if (age < 20)
            {
                Console.WriteLine(age+"kids deal:80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior citizen Dicount:90kr");
            }
            else
            {
                Console.WriteLine("Standard Price:120kr");
            }
            Console.ReadLine();
        }
        public static void RepeatTentimes()
        {
            Console.Clear();
            
            string input;
            do {
                Console.Write("what do you want to repeat:");
                input = Console.ReadLine().Trim(); ;
                if (input.Length > 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write((i + 1) + "." + input + ",");
                    }
                    Console.Write(10 + "." + input);
                }
                else {
                    Console.WriteLine("you must want to repeat something");
                }

                Console.ReadLine();
            } while (input.Length<1);
        }
        public static void Thirdword()
        {
            Console.Clear();
            bool longenough = true;
            do {

                Console.WriteLine("Please enter a sentence which contain 3 words:");
                string input = Console.ReadLine();

                string[] arrayofwords = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //It wont read gaps in betwen the sentence

                longenough = (arrayofwords.Length >2);
                if (!longenough)
                {
                    Console.WriteLine("The sentence needs atleast 3 words");
                }
                else
                {
                    Console.Write("The third word is:");
                    Console.WriteLine(arrayofwords[2]);
                }
                Console.WriteLine(arrayofwords[2]);
                Console.ReadLine();
            } while (!longenough);      
            }




    }
}

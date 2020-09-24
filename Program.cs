/*
    Author: Kaitlyn Dunne
    Date: 09-17-2020
    Comments: Demonstrates the use of conditional statements after getting input from users.
*/


using System;

namespace Dunne_TechAssignment2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try 
            {
                //Variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used in iterative statements and parsed as an integer
                int grade = int.Parse(input);

                // If the value is between 1 and 25, execute a for loop
                if ((grade > 0) && (grade < 60))
                {
                Console.WriteLine("Your grade will be an F.");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
                }

                else if ((grade <= 60) && (grade <= 69))
                {
                 Console.WriteLine("Your grade will be a D.");
                 Console.WriteLine("Press any key to exit the program...");
                 Console.ReadKey(true);
                }
                               
                else if ((grade <= 70) && (grade <= 79))
                {
                    Console.WriteLine("Your grade will be a C.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                else if ((grade <= 80) && (grade <= 89))
                {
                    Console.WriteLine("Your grade will be a B.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                else if ((grade <= 90) && (grade <= 100))
                {
                    Console.WriteLine("Your grade will be an A.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }

            catch
            {
                Console.WriteLine("Please enter an integer value between 0 and 100 and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }








        }
    }
}

using System;

namespace ConsoleUI
{
    class Progrma
    {
        static void Main(string[] args)
        {
            // program to demonstrate concept of type conversion

            //console program to get user age and decide if the user permissible to enter into the casino

            Console.WriteLine("Welcome to the Casino");
            Console.WriteLine("");

            Console.Write("Enter your age (in integer): ");

            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            if (age == 18 && age >= 18)
            {
                Console.WriteLine("Welcome, You are allowed to enter into the casino.");
            }
            else
            {
                Console.WriteLine("You are not 18 and considered as underage. However, you are not allowed inside the casino.");
                
            }



            Console.ReadLine();
        }
    }
}

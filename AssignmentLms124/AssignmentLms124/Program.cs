using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLms124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite animal:");
            string animal = Console.ReadLine().ToLower();
            bool animalGuessed = animal == "tiger";
            do
            {
                switch (animal)
                {
                    case "dog":
                        Console.WriteLine("It is not dog, guess again!");
                        Console.WriteLine("Guess an animal:");
                        animal = Console.ReadLine().ToLower();
                        break;
                    case "cat":
                        Console.WriteLine("It is not cat, guess again!");
                        Console.WriteLine("Guess an animal:");
                        animal = Console.ReadLine().ToLower();
                        break;
                    case "bird":
                        Console.WriteLine("It is not bird, guess again!");
                        Console.WriteLine("Guess an animal:");
                        animal = Console.ReadLine().ToLower();
                        break;
                    case "tiger":
                        Console.WriteLine("You are correct!");
                        animalGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You were wrong, Guess again");
                        Console.WriteLine("Guess an animal:");
                        animal = Console.ReadLine().ToLower();
                        break;

                }
            }
            while (!animalGuessed);
            Console.ReadLine();
            int number;
            bool numberGuessed = false;
            while (!numberGuessed)
            {
                Console.WriteLine("Guess a number");
                number = Convert.ToInt32(Console.ReadLine());
                if(number == 12)
                {
                    numberGuessed = true;
                    Console.WriteLine("You were Correct!");
                }
                else
                {
                    Console.WriteLine("You were wrong, guess again!");
                }
            }
            Console.ReadLine();
        }
    }
}

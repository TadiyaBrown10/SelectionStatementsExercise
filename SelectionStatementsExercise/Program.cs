using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess my favorite number");

            var r = new Random();
            var favNumber = r.Next(400);

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else
             
            {
                Console.WriteLine("nevermind");
            }
            Console.WriteLine("What is your favorite subject");

            var response = Console.ReadLine();

            switch (response)
            {
                case "History":
                    Console.WriteLine("Easy A!");
                    break;

                case "Math":
                    Console.WriteLine("You must have had an easy teacher!");
                    break;

                case "Science":
                    Console.WriteLine("The water cycle got you too right? Nice!");
                    break;

                case "English":
                    Console.WriteLine("Ok, but do you know the difference between their, there, and they're?");
                    break;

                case "PE":
                    Console.WriteLine("totally agree!");
                    break;

                default:
                    Console.WriteLine("Uhh yeah sure! Thats cool!");
                        break;
            }

        }
        
        
    }
}


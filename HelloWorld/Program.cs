using System;
using System.Reflection;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(0, 100) + 1; // will random pick number

            Console.WriteLine("Hello Player, Would you like to play a game?"); // Introduction
            Console.WriteLine("Guess the number between 1 - 100. If you guess wrong it will out put higher or lower till you get correct number."); // Instruction

            while (true)
            {
                string? userInput = Console.ReadLine();
                int.TryParse(userInput, out int guess);

                // Guess was lower
                if (guess < answer) // Checking if number is less than random number
                {
                    Console.WriteLine("Higher");
                }
                
                // Guess was higher
                if (guess > answer) // Checking if number is greater than random number
                {
                    Console.WriteLine("Lower");
                }

                if (guess == answer) // Checking if input matches the random number
                {
                    Console.WriteLine("Congrats");
                    Thread.Sleep(3000); // Delay for 3 seconds (3000 milliseconds)
                    break;
                }         
            }  
        }
    }
}

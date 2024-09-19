using static System.Console;

namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // will random pick number
            Random rnd = new Random();
            int answer = rnd.Next(0, 100) + 1;

            // Introduction
            WriteLine("Hello Player, Would you like to play a game?");

            // Instruction
            WriteLine("Guess the number between 1 - 100. If you guess wrong it will output higher or lower till you get correct number. Beware you only got 7 tries!");
            WriteLine();

            int tries = 0;
            int manyLetter = 0;
            
            while (true)
            {
                // Player Input
                string? userInput = ReadLine();
                int.TryParse(userInput, out int guess);

                // Input text error
                if (guess == 0)
                {
                    WriteLine("Please use numbers!");
                    WriteLine();
                    manyLetter++;

                    // too many letter
                    if (manyLetter == 5)
                    {
                        WriteLine("Stop using letter loser");
                        break;
                    }
                    continue;
                }

                // Guess was lower
                if (guess < answer) // Checking if number is less than random number
                {
                    Write("Higher           ");
                    tries++;
                    Write(tries);
                    Write(" Try");
                    WriteLine();
                }
                
                // Guess was higher
                if (guess > answer) // Checking if number is greater than random number
                {
                    Write("Lower            ");
                    tries++;
                    Write(tries);
                    Write(" Try");
                    WriteLine();
                }

                // answer is correct
                if (guess == answer) // Checking if input matches the random number
                {
                    WriteLine("Congrats");
                    WriteLine();
                    break;
                }

                // tries lost
                if (tries == 7)
                {
                    WriteLine("Bummer better luck next time!");
                    WriteLine();
                    break;
                }
            }
        }
    }
}
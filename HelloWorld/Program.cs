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
            Console.WriteLine("Hello Player, Would you like to play a game?");

            // Instruction
            Console.WriteLine("Guess the number between 1 - 100. If you guess wrong it will output higher or lower till you get correct number. Beware you only got 7 tries!");
            Console.WriteLine();

            int tries = 0;
            int manyLetter = 0;
            
            while (true)
            {
                // Player Input
                string? userInput = Console.ReadLine();
                int.TryParse(userInput, out int guess);

                // Input text error
                if (guess == 0)
                {
                    Console.WriteLine("Please use numbers!");
                    Console.WriteLine();
                    manyLetter++;

                    // too many letter
                    if (manyLetter == 5)
                    {
                        Console.WriteLine("Stop using letter loser");
                        break;
                    }
                    continue;
                }

                // Guess was lower
                if (guess < answer) // Checking if number is less than random number
                {
                    Console.Write("Higher           ");
                    tries++;
                    Console.Write(tries);
                    Console.Write(" Try");
                    Console.WriteLine();
                }
                
                // Guess was higher
                if (guess > answer) // Checking if number is greater than random number
                {
                    Console.Write("Lower            ");
                    tries++;
                    Console.Write(tries);
                    Console.Write(" Try");
                    Console.WriteLine();
                }

                // answer is correct
                if (guess == answer) // Checking if input matches the random number
                {
                    Console.WriteLine("Congrats");
                    Console.WriteLine();
                    break;
                }

                // tries lost
                if (tries == 7)
                {
                    Console.WriteLine("Bummer better luck next time!");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
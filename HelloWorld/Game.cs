using System.Data;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using static System.Console;

namespace Belden
{
    public class Game
    {
        int GetAnswer()
        {
            var rnd = new Random();
            return rnd.Next(0, 100) + 1;
        }

        int GetInput()
        {
            var userInput = ReadLine();
            int.TryParse(userInput, out int guess);
            return guess;
        }

        void Write(string message)
        {
            WriteLine(message);
            WriteLine();
        }

        void MessageUser(int answer, int guess, int tries, int tooManyLetters)
        {
            switch (guess)
            {

                case 0:
                    {
                        Write("Please use numbers!");

                        if (tooManyLetters == 5)
                        {
                            Write("Stop using letters loser");
                        }
                        break;
                    }

                case < answer:
                    {
                        Write($"Higher    {tries} Tries");
                        break;
                    }

                case > answer:
                    {
                        Write($"Lower      {tries} Tries");
                        break;
                    }
            }
        }

        void Loop(int answer)
        {

            var tries = 0;
            var tooManyLetters = 0;

            while (true)
            {
                tries++;
                var guess = GetInput();

                if (guess == answer)
                {
                    Write("Congrats");
                    return;
                }

                if (tries == 7)
                {
                    Write("Bummer better luck next time!");
                    return;
                }

                if (guess == 0)
                {
                    tooManyLetters++;
                    continue;
                }

                MessageUser(guess, tries, tooManyLetters);
            }
        }

        public void Run()
        {
            var answer = GetAnswer();

            Write("Hello Player, Would you like to play a game?");
            Write("Guess the number between 1 - 100. If you guess wrong it will output higher or lower till you get correct number. Beware you only got 7 tries!");

            Loop(answer);
        }
    }
}
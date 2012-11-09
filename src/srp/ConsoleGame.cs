using System;
using System.Text.RegularExpressions;
using OOLessons.OOLessons.src.srp;
using OOLessons.srp;

namespace OOLessons.test.srp
{
    internal class ConsoleGame
    {
        private Guess guess;

        public ConsoleGame(Guess guess)
        {
            this.guess = guess;
        }

        public void Start()
        {
            Console.WriteLine("Your Guess ?");
            var result = guess.Do(Console.ReadLine());
            while (!result.Equals("4B0C"))
            {
                ShowSugession(result);
                Console.WriteLine("Your next Guess ?");
            }

            Console.ReadKey();
        }

        public void ShowSugession(string result)
        {
            try
            {
                if (result.Equals("4B0C"))
                    Console.WriteLine("Congratulations! You have won!");
                else
                {
                    var regex = new Regex("(\\d)B(\\d)C");
                    Match match = regex.Match(result);
                    Console.WriteLine("Your Score is {0} bulls and {1} cows", match.Groups[1], match.Groups[2]);
                }
            }
            catch (InvalidGuessException e)
            {
                Console.WriteLine("Not a valid guess.");
            }
            catch (DigitNotInvalidNumberException e)
            {
                Console.WriteLine("Digit must be ge greater 0 and lower 10.");
            }
        }
    }
}
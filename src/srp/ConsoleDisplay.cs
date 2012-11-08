using System;
using System.Text.RegularExpressions;
using OOLessons.test.srp;

namespace OOLessons.srp
{
    public class ConsoleDisplay
    {
        private Game game;

        public ConsoleDisplay(Game game)
        {
            this.game = game;
        }

        public void Play(string guess)
        {
            try
            {
                var result = game.Compute(guess);
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
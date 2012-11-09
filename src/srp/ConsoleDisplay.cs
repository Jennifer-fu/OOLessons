using System;
using System.Text.RegularExpressions;
using OOLessons.OOLessons.src.srp;
using OOLessons.srp;

namespace OOLessons.test.srp
{
    public class ConsoleDisplay
    {
        public void NextGuessPrompt()
        {
            Console.WriteLine("Your next Guess ?");
        }

        public string GuessInput()
        {
            //Console.ReadKey();
            return Console.ReadLine();
        }

        public void GuessPrompt()
        {
            Console.WriteLine("Your Guess ?");
        }
     
        public void NotDigitGuess()
        {
            Console.WriteLine("Digit must be ge greater 0 and lower 10.");
        }

        public void InvalidGuess()
        {
            Console.WriteLine("Not a valid guess.");
        }

        public void FailGuess(string result)
        {
            var regex = new Regex("(\\d)B(\\d)C");
            Match match = regex.Match(result);
            Console.WriteLine("Your Score is {0} bulls and {1} cows", match.Groups[1], match.Groups[2]);
        }

        public void SuccessGuess()
        {
            Console.WriteLine("Congratulations! You have won!");
        }
    }
}
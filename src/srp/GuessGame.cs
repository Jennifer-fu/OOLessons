using System;
using OOLessons.test.srp;

namespace OOLessons.srp
{
    public class GuessGame
    {
        private readonly ConsoleDisplay console;
        private readonly GuessAgorithm guess;

        public GuessGame(ConsoleDisplay console, GuessAgorithm guess)
        {
            this.console = console;
            this.guess = guess;
        }

        public void Start()
        {
            console.GuessPrompt();
            string result = String.Empty;
            do
            {
                result = guess.Do(console.GuessInput());
                ShowSugession(result);
                console.NextGuessPrompt();

            } while (!Success(result));
        }

        private bool Success(string result)
        {
            return result.Equals("4B0C");
        }

        private void ShowSugession(string result)
        {
            try
            {
                if (Success(result)) console.SuccessGuess();
                else console.FailGuess(result);
            }
            catch (InvalidGuessException e)
            {
                console.InvalidGuess();
            }
            catch (DigitNotInvalidNumberException e)
            {
                console.NotDigitGuess();
            }
        }
    }
}
using System;
using OOLessons.OOLessons.src.srp;
using OOLessons.srp;

namespace OOLessons.test.srp
{
    public class GuessAgorithm
    {
        private readonly int[] answer;

        public GuessAgorithm(RandomAnswerGenerator randomAnswerGenerator)
        {
            var nums = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            answer = randomAnswerGenerator.KnuthShuffle(nums);
            Array.Copy(nums, answer, 4);
        }

        public string Do(string guess)
        {
            Validate(guess);
            var bullsCount = ComputeBullsCount(guess);
            var cowsCount = ComputeCowsCount(guess);
            return String.Format("{0}B{1}C", bullsCount, cowsCount);
        }

        private int ComputeCowsCount(string guess)
        {
            char[] guessed = guess.ToCharArray();
            int cowsCount = 0;
            for (int i = 0; i < 4; i++)
            {
                int curguess = (int) char.GetNumericValue(guessed[i]);
                if (curguess != answer[i])
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (curguess == answer[j])
                            cowsCount++;
                    }
                }
            }
            return cowsCount;
        }

        private int ComputeBullsCount(string guess)
        {
            char[] guessed = guess.ToCharArray();
            int bullsCount = 0;
            for (int i = 0; i < 4; i++)
            {
                int curguess = (int) char.GetNumericValue(guessed[i]);
                if (curguess == answer[i])
                {
                    bullsCount++;
                }
            }
            return bullsCount;
        }

        private void Validate(string guess)
        {
            char[] guessed = guess.ToCharArray();
            if (guessed.Length != 4)
            {
                throw new InvalidGuessException();
            }

            for (int i = 0; i < 4; i++)
            {
                int curguess = (int) char.GetNumericValue(guessed[i]);
                if (curguess < 1 || curguess > 9)
                {
                    throw new DigitNotInvalidNumberException();
                }
            }
        }
    }
}
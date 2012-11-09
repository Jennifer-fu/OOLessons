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
            char[] guessed = guess.ToCharArray();
            int bullsCount = 0, cowsCount = 0;
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
                if (curguess == answer[i])
                {
                    bullsCount++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (curguess == answer[j])
                            cowsCount++;
                    }
                }
            }
            return String.Format("{0}B{1}C", bullsCount, cowsCount);
        }
    }
}
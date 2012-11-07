using System;

namespace OOLessons.test.srp
{
    public class Game
    {
        public void KnuthShuffle<T>(ref T[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(array.Length);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        public bool play(string guess, int[] num)
        {
            char[] guessed = guess.ToCharArray();
            int bullsCount = 0, cowsCount = 0;

            if (guessed.Length != 4)
            {
                Console.WriteLine("Not a valid guess.");
                return false;
            }

            for (int i = 0; i < 4; i++)
            {
                int curguess = (int) char.GetNumericValue(guessed[i]);
                if (curguess < 1 || curguess > 9)
                {
                    Console.WriteLine("Digit must be ge greater 0 and lower 10.");
                    return false;
                }
                if (curguess == num[i])
                {
                    bullsCount++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (curguess == num[j])
                            cowsCount++;
                    }
                }
            }

            if (bullsCount == 4)
            {
                Console.WriteLine("Congratulations! You have won!");
                return true;
            }
            Console.WriteLine("Your Score is {0} bulls and {1} cows", bullsCount, cowsCount);
            return false;
        }
    }
}

}
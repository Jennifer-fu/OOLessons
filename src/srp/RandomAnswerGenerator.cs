using System;

namespace OOLessons.OOLessons.src.srp
{
    public class RandomAnswerGenerator
    {
        public virtual T[] KnuthShuffle<T>(T[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(array.Length);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }
    }
}
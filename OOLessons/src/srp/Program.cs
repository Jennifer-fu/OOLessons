using System;

namespace OOLessons.test.srp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var game = new Game();
            int[] nums = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            game.KnuthShuffle<int>(ref nums);
            int[] chosenNum = new int[4];
            Array.Copy(nums, chosenNum, 4);

            Console.WriteLine("Your Guess ?");
            while (!game.play(Console.ReadLine(), chosenNum))
            {
                Console.WriteLine("Your next Guess ?");
            }

            Console.ReadKey();
        }
    }
}
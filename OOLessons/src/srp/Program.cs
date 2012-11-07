using System;

namespace OOLessons.test.srp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var game = new Game();
            
            Console.WriteLine("Your Guess ?");
            while (!game.Play(Console.ReadLine()))
            {
                Console.WriteLine("Your next Guess ?");
            }

            Console.ReadKey();
        }
    }
}
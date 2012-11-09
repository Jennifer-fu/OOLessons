using OOLessons.OOLessons.src.srp;
using OOLessons.test.srp;

namespace OOLessons.srp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new GuessGame(new ConsoleDisplay(), new GuessAgorithm(new RandomAnswerGenerator()));
            game.Start();
        }
    }
}
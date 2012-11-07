using Moq;
using NUnit.Framework;
using OOLessons.OOLessons.src.srp;
using OOLessons.test.srp;

namespace OOLessons.srp
{
    public class GameTest
    {
        [Test]
        public void should_success_if_enter_the_right_answer()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[]{1,2,3,4});
            var game = new Game(mock.Object);
            Assert.IsTrue(game.Play("1234"));
        }
    }
}
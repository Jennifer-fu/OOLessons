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
            Assert.AreEqual("4B0C",game.Play1("1234"));
        }

        [Test]
        public void should_return_0_bulls_and_0_cows_if_enter_5678_and_right_answer_is_1234()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Game(mock.Object);
            Assert.AreEqual("0B0C",game.Play1("5678"));
        }

        [Test]
        public void should_return_1_bulls_and_0_cows_if_enter_1678_and_right_answer_is_1234()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Game(mock.Object);
            Assert.AreEqual("1B0C", game.Play1("1678"));
        }

        [Test]
        public void should_return_1_bulls_and_1_cows_if_enter_1628_and_right_answer_is_1234()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Game(mock.Object);
            Assert.AreEqual("1B1C", game.Play1("1628"));
        }

        [Test]
        public void should_return_0_bulls_and_4_cows_if_enter_3142_and_right_answer_is_1234()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Game(mock.Object);
            Assert.AreEqual("0B4C", game.Play1("3142"));
        }
    }
}
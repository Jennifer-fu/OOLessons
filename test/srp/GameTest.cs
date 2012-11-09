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
            var game = new Guess(mock.Object);
            Assert.AreEqual("4B0C",game.Do("1234"));
        }

        [Test]
        public void should_return_0_bulls_and_0_cows_if_enter_5678_and_right_answer_is_1234()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Guess(mock.Object);
            Assert.AreEqual("0B0C",game.Do("5678"));
        }

        [Test]
        public void should_return_1_bulls_and_0_cows_if_enter_1678_and_right_answer_is_1234()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Guess(mock.Object);
            Assert.AreEqual("1B0C", game.Do("1678"));
        }

        [Test]
        public void should_return_1_bulls_and_1_cows_if_enter_1628_and_right_answer_is_1234()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Guess(mock.Object);
            Assert.AreEqual("1B1C", game.Do("1628"));
        }

        [Test]
        public void should_return_0_bulls_and_4_cows_if_enter_3142_and_right_answer_is_1234()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Guess(mock.Object);
            Assert.AreEqual("0B4C", game.Do("3142"));
        }

        [Test]
        [ExpectedException(typeof(DigitNotInvalidNumberException))]
        public void should_return_throw_exception_if_enter_number_not_between_1_to_9()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Guess(mock.Object);
            game.Do("abcd");
        }

        [Test]
        [ExpectedException(typeof(InvalidGuessException))]
        public void should_throw_exception_if_enter_not_4_numbers()
        {
            var mock = new Mock<RandomAnswerGenerator>();
            mock.Setup(m => m.KnuthShuffle(It.IsAny<int[]>())).Returns(new[] { 1, 2, 3, 4 });
            var game = new Guess(mock.Object);
            game.Do("314");
        }
    }
}
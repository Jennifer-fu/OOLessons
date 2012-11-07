using NUnit.Framework;
using OOLessons.test;

namespace OOLessons
{
    public static class ChanceExtension
    {
        public static void ShouldEqual(this Chance chance, Chance other)
        {
            Assert.AreEqual(chance,other);
        }

        public static void ShouldNotEqual(this Chance chance, object other)
        {
            Assert.AreNotEqual(chance,other);
        }
    }
}
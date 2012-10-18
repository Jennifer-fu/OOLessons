using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OOLessons.test;

namespace OOLessons
{
    public class ChanceTest
    {
        [Test]
        public void chance_of_0dot1_should_equal_chance_of_0dot1()
        {
            var chanceOf0Dot1 = new Chance(0.1);
            var anotherChanceOf0Dot1 = new Chance(0.1);

            chanceOf0Dot1.ShouldEqual(anotherChanceOf0Dot1);
        }

        [Test]
        public void chance_of_0dot1_should_equal_chance_of_0dot2()
        {
            var chanceOf0Dot1 = new Chance(0.1);
            var chanceOf0Dot2 = new Chance(0.2);

            chanceOf0Dot1.ShouldEqual(chanceOf0Dot2);
        }

        [Test]
        public void chance_of_0dot1_should_not_equal_any_object()
        {
            var chanceOf0Dot1 = new Chance(0.1);
            var anyObject = new object();

            chanceOf0Dot1.ShouldNotEqual(anyObject);
        }
    }
}

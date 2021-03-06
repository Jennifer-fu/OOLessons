﻿using System;
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

            chanceOf0Dot1.ShouldNotEqual(chanceOf0Dot2);
        }

        [Test]
        public void chance_of_0dot1_should_not_equal_any_object()
        {
            var chanceOf0Dot1 = new Chance(0.1);
            var anyObject = new object();

            chanceOf0Dot1.ShouldNotEqual(anyObject);
        }

        [Test]
        public void chance_of_not_0dot1_should_equal_chance_of_0dot9()
        {
            var chanceOf0Dot1 = new Chance(0.1);
            var chanceOf0Dot9 = new Chance(0.9);

            chanceOf0Dot1.Not().ShouldEqual(chanceOf0Dot9);
        }

        [Test]
        public void chance_of_0dot1_and_chance_of_0dot1_should_equal_chance_of_0dot01()
        {
            var chanceOf0Dot1 = new Chance(0.1);
            var chanceOf0Dot01 = new Chance(0.01);

            chanceOf0Dot1.And(chanceOf0Dot1).ShouldEqual(chanceOf0Dot01);
        }

        [Test]
        public void chance_of_0dot1_or_chance_of_0dot1_should_equal_chance_of_0dot19()
        {
            var chanceOf0Dot1 = new Chance(0.1);
            var chanceOf0Dot19 = new Chance(0.19);

            chanceOf0Dot1.Or(chanceOf0Dot1).ShouldEqual(chanceOf0Dot19);
        }
    }
}

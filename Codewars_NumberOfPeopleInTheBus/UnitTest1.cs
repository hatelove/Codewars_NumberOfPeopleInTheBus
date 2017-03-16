using NUnit.Framework;
using System.Collections.Generic;

namespace Codewars_NumberOfPeopleInTheBus
{
    [TestFixture]
    public class MyTest
    {
        [Test]
        public void only_1_station()
        {
            var p = new List<int[]>() { new[] { 10, 1 } };
            RemainPassengerShouldBe(p, 9);
        }

        [Test]
        public void there_were_2_stations()
        {
            var p = new List<int[]>()
            {
                new[] { 10, 1 },
                new[] { 3, 5 },
            };

            RemainPassengerShouldBe(p, 7);
        }

        private static void RemainPassengerShouldBe(List<int[]> p, int expected)
        {
            Assert.AreEqual(expected, Kata.Number(p));
        }

        [Ignore("codewars")]
        [Test]
        public void FirstTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(5, Kata.Number(peopleList));
        }

        [Ignore("codewars")]
        [Test]
        public void SecondTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            Assert.AreEqual(17, Kata.Number(peopleList));
        }

        [Ignore("codewars")]
        [Test]
        public void ThirdTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
            Assert.AreEqual(21, Kata.Number(peopleList));
        }
    }

    public class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            var station = peopleListInOut[0];
            return station[0] - station[1];
        }
    }
}
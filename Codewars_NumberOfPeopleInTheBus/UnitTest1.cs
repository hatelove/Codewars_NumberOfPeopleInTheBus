﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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

        [Test]
        public void there_were_3_stations()
        {
            var p = new List<int[]>()
            {
                new[] { 10, 1 },
                new[] { 3, 5 },
                new[] { 0,1}
            };

            RemainPassengerShouldBe(p, 6);
        }

        private static void RemainPassengerShouldBe(List<int[]> p, int expected)
        {
            Assert.AreEqual(expected, Kata.Number(p));
        }

        [Test]
        public void FirstTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(5, Kata.Number(peopleList));
        }

        [Test]
        public void SecondTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            Assert.AreEqual(17, Kata.Number(peopleList));
        }

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
            return peopleListInOut.Aggregate(0,
                (s, x) => s + RemainPassengerCountOfCurrentStation(x));
        }

        private static int RemainPassengerCountOfCurrentStation(int[] station)
        {
            return station[0] - station[1];
        }
    }
}
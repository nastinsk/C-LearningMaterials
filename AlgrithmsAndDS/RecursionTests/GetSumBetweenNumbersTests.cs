using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Tests
{
    [TestClass()]
    public class GetSumBetweenNumbersTests
    {

        [TestMethod()]
        public void GetSumBetweenNumberIterationTest()
        {
            int expected = 10;
            int actual = GetSumBetweenNumbers.GetSumBetweenNumbersIteration(1, 4);
            Assert.AreEqual(expected, actual, "returned sum is not correct");
        }

        [TestMethod()]
        public void GetSumBetweenNumberIterationTest1()
        {
            int expected = 0;
            int actual = GetSumBetweenNumbers.GetSumBetweenNumbersIteration(4, 1);
            Assert.AreEqual(expected, actual, "returned sum is not 0");
        }

        [TestMethod()]
        public void GetSumBetweenNumberIterationTest2()
        {
            int expected = 7;
            int actual = GetSumBetweenNumbers.GetSumBetweenNumbersIteration(7, 7);
            Assert.AreEqual(expected, actual, $"returned sum is not 7 but {actual}");
        }
        [TestMethod()]
        public void GetSumBetweenNumberIterationTest3()
        {
            int expected = 9;
            int actual = GetSumBetweenNumbers.GetSumBetweenNumbersIteration(-3, 5);
            Assert.AreEqual(expected, actual, "returned sum is not 9");
        }

        [TestMethod()]
        public void GetSumBetweenNumbersRecursionTest()
        {
            int expected = 10;
            int actual = GetSumBetweenNumbers.GetSumBetweenNumbersRecursion(1, 4);
            Assert.AreEqual(expected, actual, "returned sum is not correct");
        }

        [TestMethod()]
        public void GetSumBetweenNumbersRecursionTest1()
        {
            int expected = 0;
            int actual = GetSumBetweenNumbers.GetSumBetweenNumbersRecursion(4, 1);
            Assert.AreEqual(expected, actual, "returned sum is not correct");
        }

        [TestMethod()]
        public void GetSumBetweenNumbersRecursionTest2()
        {
            int expected = 7;
            int actual = GetSumBetweenNumbers.GetSumBetweenNumbersRecursion(7, 7);
            Assert.AreEqual(expected, actual, "returned sum is not correct");
        }

        [TestMethod()]
        public void GetSumBetweenNumbersRecursionTest3()
        {
            int expected = 9;
            int actual = GetSumBetweenNumbers.GetSumBetweenNumbersRecursion(-3, 5);
            Assert.AreEqual(expected, actual, "returned sum is not correct");
        }
    }
}
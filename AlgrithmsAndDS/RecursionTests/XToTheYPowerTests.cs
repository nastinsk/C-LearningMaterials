using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Tests
{
    [TestClass()]
    public class XToTheYPowerTests
    {
        [TestMethod()]
        public void XToTheYPowerIterationTest()
        {
            int expected = 27;
            int actual = XToTheYPower.XToTheYPowerIteration(3, 3);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerIterationTest1()
        {
            int expected = -27;
            int actual = XToTheYPower.XToTheYPowerIteration(-3, 3);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerIterationTest2()
        {
            int expected = 0;
            int actual = XToTheYPower.XToTheYPowerIteration(0, 20);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerIterationTest3()
        {
            int expected = -9;
            int actual = XToTheYPower.XToTheYPowerIteration(-9, 1);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerIterationTest4()
        {
            int expected = 81;
            int actual = XToTheYPower.XToTheYPowerIteration(-9, 2);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerIterationTest5()
        {
            int expected = 1;
            int actual = XToTheYPower.XToTheYPowerIteration(-9, 0);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerRecursionTest()
        {
            int expected = 27;
            int actual = XToTheYPower.XToTheYPowerRecursion(3, 3);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerRecursionTest1()
        {
            int expected = -27;
            int actual = XToTheYPower.XToTheYPowerRecursion(-3, 3);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerRecursionTest2()
        {
            int expected = 0;
            int actual = XToTheYPower.XToTheYPowerRecursion(0, 20);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerRecursionTest3()
        {
            int expected = -9;
            int actual = XToTheYPower.XToTheYPowerRecursion(-9, 1);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerRecursionTest4()
        {
            int expected = 81;
            int actual = XToTheYPower.XToTheYPowerRecursion(-9, 2);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }

        [TestMethod()]
        public void XToTheYPowerRecursionTest5()
        {
            int expected = 1;
            int actual = XToTheYPower.XToTheYPowerRecursion(-9, 0);
            Assert.AreEqual(expected, actual, "returned value is not correct");
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Tests
{
    [TestClass()]
    public class ReverseStringTests
    {
        [TestMethod()]
        public void ReverseStringIterationTest()
        {
            string input = "hello";
            string expected = "olleh";
            string actual = ReverseString.ReverseStringIteration(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");
        }


        [TestMethod()]
        public void ReverseStringIterationTest2()
        {
            string input = "helloo";
            string expected = "oolleh";
            string actual = ReverseString.ReverseStringIteration(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");
        }

        [TestMethod()]
        public void ReverseStringIterationTest3()
        {
            string input = "HelLoo";
            string expected = "ooLleH";
            string actual = ReverseString.ReverseStringIteration(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");
        }

        [TestMethod()]
        public void ReverseStringIterationTest4()
        {
            string input = "";
            string expected = "";
            string actual = ReverseString.ReverseStringIteration(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");
        }

        [TestMethod()]
        public void ReverseStringIterationTest5()
        {
            string input = "1";
            string expected = "1";
            string actual = ReverseString.ReverseStringIteration(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");
        }


        [TestMethod()]
        public void ReverseStringRecursionTest()
        {
            string input = "abcdef";
            string expected = "fedcba";
            string actual = ReverseString.ReverseStringRecursion(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");

        }

        [TestMethod()]
        public void ReverseStrinRecursionTest2()
        {
            string input = "helloo";
            string expected = "oolleh";
            string actual = ReverseString.ReverseStringRecursion(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");
        }
        [TestMethod()]
        public void ReverseStrinRecursionTest3()
        {
            string input = "";
            string expected = "";
            string actual = ReverseString.ReverseStringRecursion(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");
        }

        [TestMethod()]
        public void ReverseStrinRecursionTest4()
        {
            string input = "6";
            string expected = "6";
            string actual = ReverseString.ReverseStringRecursion(input);
            Assert.AreEqual(expected, actual, "string is not reversed correctly");
        }
    }
}
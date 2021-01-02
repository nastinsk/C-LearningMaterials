using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BruteForce;



namespace TestBruteForce
{
    [TestClass]
    public class BruteForceUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expected = false;
            string inputStr = "efbggd";
            bool actual = Program.IsFirstCharRepeated(inputStr);
            Assert.AreEqual(expected, actual, "function sees that string has repeated first character, which is not true");

        }
        [TestMethod]
        public void TestMethod2()
        {
            bool expected = true;
            string inputStr = "efbgged";
            bool actual = Program.IsFirstCharRepeated(inputStr);
            Assert.AreEqual(expected, actual, "function sees that string doesn't have repeated first character, which is not true");

        }
        [TestMethod]
        public void TestMethod3()
        {
            bool expected = true;
            string inputStr = "134343133";
            bool actual = Program.IsFirstCharRepeated(inputStr);
            Assert.AreEqual(expected, actual, "function sees that string doesn't have repeated first character, which is not true");

        }
    }
}

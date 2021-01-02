using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DivideAndConquer.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MultiplyListIretaionTest()
        {
            var inputList = new List<int> { 3, 2, 4 };
            int expected = 24;

            int actual = DivideAndConquer.Program.MultiplyListIretaion(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

        [TestMethod()]
        public void MultiplyListIretaionTest1()
        {
            var inputList = new List<int> { 3, 2, 4, 0 };
            int expected = 0;

            int actual = DivideAndConquer.Program.MultiplyListIretaion(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

        [TestMethod()]
        public void MultiplyListIretaionTest2()
        {
            var inputList = new List<int> { -3, 2, -4 };
            int expected = 24;

            int actual = DivideAndConquer.Program.MultiplyListIretaion(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

        [TestMethod()]
        public void MultiplyListIretaionTest3()
        {
            var inputList = new List<int> { 1, 1, -1 };
            int expected = -1;

            int actual = DivideAndConquer.Program.MultiplyListIretaion(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

        [TestMethod()]
        public void MultiplyListIretaionTest4()
        {
            var inputList = new List<int> { };
            int expected = 0;

            int actual = DivideAndConquer.Program.MultiplyListIretaion(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

        [TestMethod()]
        public void MultiplyListDivideAndConquerTest()
        {
            var inputList = new List<int> { 3, 2, 4 };
            int expected = 24;

            int actual = DivideAndConquer.Program.MultiplyListDivideAndConquer(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

        [TestMethod()]
        public void MultiplyListDivideAndConquerTest1()
        {
            var inputList = new List<int> { 3, 2, 4, 0 };
            int expected = 0;

            int actual = DivideAndConquer.Program.MultiplyListDivideAndConquer(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

        [TestMethod()]
        public void MultiplyListDivideAndConquerTest2()
        {
            var inputList = new List<int> { -3, 2, -4 };
            int expected = 24;

            int actual = DivideAndConquer.Program.MultiplyListDivideAndConquer(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

        [TestMethod()]
        public void MultiplyListDivideAndConquerTest3()
        {
            var inputList = new List<int> { 1, 1, -1 };
            int expected = -1;

            int actual = DivideAndConquer.Program.MultiplyListDivideAndConquer(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }


        [TestMethod()]
        public void MultiplyListDivideAndConquerTest4()
        {
            var inputList = new List<int> {};
            int expected = 0;

            int actual = DivideAndConquer.Program.MultiplyListDivideAndConquer(inputList);
            Assert.AreEqual(expected, actual, "list product is not correct");
        }

    }
}
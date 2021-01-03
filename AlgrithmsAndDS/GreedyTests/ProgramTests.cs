using Microsoft.VisualStudio.TestTools.UnitTesting;
using Greedy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Greedy.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FillRoomWithBoxesTest()
        {
            var boxSizes = new List<int> { 7, 3, 1 };
            var boxes = new List<int> { };
            var expected = new List<int> { 7, 7, 7, 3, 1 };
            var actual = Greedy.Program.FillRoomWithBoxes(25, boxSizes, boxes);
            Assert.AreEqual(expected[0], actual[0], "error in 1st element");
            Assert.AreEqual(expected[1], actual[1], "error in 2nd element");
            Assert.AreEqual(expected[2], actual[2], "error in 3rd element");
            Assert.AreEqual(expected[3], actual[3], "error in 4th element");
            Assert.AreEqual(expected[4], actual[4], "error in 5th element");
        }

        [TestMethod()]
        public void CompareListsWithLinq()
        {
            var boxSizes = new List<int> { 7, 3, 1 };
            var boxes = new List<int> { };
            var expectedList = new List<int> { 7, 7, 7, 3, 1 };
            var actualList = Greedy.Program.FillRoomWithBoxes(25, boxSizes, boxes);
            bool expected = expectedList.SequenceEqual(actualList);
            Assert.AreEqual(expected, true, "lists are not equal");
        }

        [TestMethod()]
        public void CompareListsEmptyBoxSizes()
        {
            var boxSizes = new List<int> { };
            var boxes = new List<int> { };
            var expectedList = new List<int> { };
            var actualList = Greedy.Program.FillRoomWithBoxes(25, boxSizes, boxes);
            bool expected = expectedList.SequenceEqual(actualList);
            Assert.AreEqual(expected, true, "lists are not equal");
        }

        [TestMethod()]
        public void CompareListsZeroRoomSize()
        {
            var boxSizes = new List<int> {7, 3, 1 };
            var boxes = new List<int> { };
            var expectedList = new List<int> { };
            var actualList = Greedy.Program.FillRoomWithBoxes(0, boxSizes, boxes);
            bool expected = expectedList.SequenceEqual(actualList);
            Assert.AreEqual(expected, true, "lists are not equal");
        }

        [TestMethod()]
        public void CompareListsOnlyFristElUsed()
        {
            var boxSizes = new List<int> { 5, 3, 2 };
            var boxes = new List<int> { };
            var expectedList = new List<int> {5, 5};
            var actualList = Greedy.Program.FillRoomWithBoxes(10, boxSizes, boxes);
            bool expected = expectedList.SequenceEqual(actualList);
            Assert.AreEqual(expected, true, "lists are not equal");
        }

        [TestMethod()]
        public void CompareListsOnlyFristElUsed2()
        {
            var boxSizes = new List<int> { 5, 3, 2 };
            var boxes = new List<int> { };
            var expectedList = new List<int> { 5, 5 };
            var actualList = Greedy.Program.FillRoomWithBoxes(11, boxSizes, boxes);
            bool expected = expectedList.SequenceEqual(actualList);
            Assert.AreEqual(expected, true, "lists are not equal");
        }

    }
}
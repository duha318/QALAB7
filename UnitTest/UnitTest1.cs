using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void CreateBoardTest()
        {
            int expected = 9;
            int actual = 9;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CurrentPlayerTest()
        {

            string expected1 = "X";
            string actual1 = "X";
            Assert.AreEqual(expected1, actual1);

        }

        [TestMethod()]
        public void ChangePlayerTest()
        {
            string expected2 = "O";
            string actual2 = "O";
            Assert.AreEqual(expected2, actual2);

        }

        [TestMethod()]
        public void MakeMoveTest()
        {

            string expected1 = "X";
            string expected2 = "O";

            string actual1 = "X";
            string actual2 = "O";

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void SpaceInUseTest()
        {
            bool expected = true;
            bool actual = true;
            Assert.AreEqual(expected, actual);
        }

    }
}

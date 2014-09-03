using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex033Test
    {
        [TestMethod]
        public void LeetCode_Ex033_Test_SearchRange1()
        {
            int[] t = { 5, 7, 7, 8, 8, 10 };
            List<int> r = Ex033.SearchRange(t, 8);
            Assert.AreEqual(3, r[0]);
            Assert.AreEqual(4, r[1]);
        }

        [TestMethod]
        public void LeetCode_Ex033_Test_SearchRange2()
        {
            int[] t = { 5, 5 };
            List<int> r = Ex033.SearchRange(t, 5);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(1, r[1]);
        }

        [TestMethod]
        public void LeetCode_Ex033_Test_SearchRange3()
        {
            int[] t = { 1, 5 };
            List<int> r = Ex033.SearchRange(t, 5);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(1, r[1]);
        }

        [TestMethod]
        public void LeetCode_Ex033_Test_SearchRange4()
        {
            int[] t = { 1, 5 };
            List<int> r = Ex033.SearchRange(t, 8);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
        }

        [TestMethod]
        public void LeetCode_Ex033_Test_SearchRange5()
        {
            int[] t = { 0 };
            List<int> r = Ex033.SearchRange(t, 8);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
        }

        [TestMethod]
        public void LeetCode_Ex033_Test_SearchRange6()
        {
            int[] t = { 8 };
            List<int> r = Ex033.SearchRange(t, 9);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
        }
    };
}
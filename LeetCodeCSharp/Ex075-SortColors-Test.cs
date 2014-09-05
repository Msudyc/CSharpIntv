using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex075Test
    {
        [TestMethod]
        public void LeetCode_Ex075_Test_SortColors1()
        {
            int[] t = {1, 2, 1, 0, 1, 0};
            Ex075.SortColors(t);
            Assert.AreEqual(0, t[0]);
            Assert.AreEqual(0, t[1]);
            Assert.AreEqual(1, t[2]);
            Assert.AreEqual(1, t[3]);
            Assert.AreEqual(1, t[4]);
            Assert.AreEqual(2, t[5]);
        }

        [TestMethod]
        public void LeetCode_Ex075_Test_SortColors2()
        {
            int[] t = {1};
            Ex075.SortColors(t);
            Assert.AreEqual(1, t[0]);
        }

        [TestMethod]
        public void LeetCode_Ex075_Test_SortColors3()
        {
            int[] t = {1, 2};
            Ex075.SortColors(t);
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex122Test
    {
        [TestMethod]
        public void LeetCode_Ex122_Test_MaxProfit1()
        {
            int[] r0 = {1, 4, 3, 2, 6, 7, 4, 8, 9, 2};
            Assert.AreEqual(13, Ex122.MaxProfit(r0));
        }

        [TestMethod]
        public void LeetCode_Ex122_Test_MaxProfit2()
        {
            int[] r0 = { 1 };
            Assert.AreEqual(0, Ex122.MaxProfit(r0));
        }

        [TestMethod]
        public void LeetCode_Ex122_Test_MaxProfit3()
        {
            int[] r0 = { 1, 4 };
            Assert.AreEqual(3, Ex122.MaxProfit(r0));
        }

        [TestMethod]
        public void LeetCode_Ex122_Test_MaxProfit4()
        {
            int[] r0 = { 1, 4, 0, 2 };
            Assert.AreEqual(5, Ex122.MaxProfit(r0));
        }
    };
}
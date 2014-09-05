using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex074Test
    {
        [TestMethod]
        public void LeetCode_Ex074_Test_SearchMatrix1()
        {
            int[,] t = { { 1, 2, 3 }, { 5, 7, 9 }, { 10, 13, 15 } };
            Assert.IsTrue(Ex074.SearchMatrix(t, 9));
        }

        [TestMethod]
        public void LeetCode_Ex074_Test_SearchMatrix2()
        {
            int[,] t = {{1, 2, 3}, {5, 7, 9}, {10, 13, 15}};
            Assert.IsFalse(Ex074.SearchMatrix(t, 11));
        }
    };
}
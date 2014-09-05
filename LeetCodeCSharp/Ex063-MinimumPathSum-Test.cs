using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex063Test
    {
        [TestMethod]
        public void LeetCode_Ex063_Test_MinPathSum1()
        {
            int [,] t = {{0, 2, 0}, {0, 1, 3}, {1, 1, 0}};
            Assert.AreEqual(2, Ex063.MinPathSum(t));
        }

        [TestMethod]
        public void LeetCode_Ex063_Test_MinPathSum2()
        {
            int [,] t = {{0, 2, 0, 1}, {0, 1, 3, 2}, {1, 1, 0, 3}};
            Assert.AreEqual(5, Ex063.MinPathSum(t));
        }

        [TestMethod]
        public void LeetCode_Ex063_Test_MinPathSum3()
        {
            int[,] t = {{0, 2, 0, 1}};
            Assert.AreEqual(3, Ex063.MinPathSum(t));
        }

        [TestMethod]
        public void LeetCode_Ex063_Test_MinPathSum4()
        {
            int[,] t = { { 0, 2, 0 }, { 0, 1, 3 }, { 1, 1, 0 } };
            Assert.AreEqual(2, Ex063.MinPathSumDP(t));
        }

        [TestMethod]
        public void LeetCode_Ex063_Test_MinPathSum5()
        {
            int[,] t = { { 0, 2, 0, 1 }, { 0, 1, 3, 2 }, { 1, 1, 0, 3 } };
            Assert.AreEqual(5, Ex063.MinPathSumDP(t));
        }

        [TestMethod]
        public void LeetCode_Ex063_Test_MinPathSum6()
        {
            //int[,] t = { { 0, 2, 0, 1 } };
            //Assert.AreEqual(3, Ex063.MinPathSumDP(t));
        }
    };
}
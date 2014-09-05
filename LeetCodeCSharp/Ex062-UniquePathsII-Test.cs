using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex062Test
    {
        [TestMethod]
        public void LeetCode_Ex062_Test_UniquePathsWithObstacles1()
        {
            int[,] t = {{0, 0, 0}, {0, 1, 0}, {0, 0, 0}};
            Assert.AreEqual(2, Ex062.UniquePathsWithObstacles(t));
        }

        [TestMethod]
        public void LeetCode_Ex062_Test_UniquePathsWithObstacles2()
        {
            int[,] t = { { 0, 0, 0 }, { 0, 1, 1 }, { 0, 0, 0 } };
            Assert.AreEqual(1, Ex062.UniquePathsWithObstacles(t));
        }

        [TestMethod]
        public void LeetCode_Ex062_Test_UniquePathsWithObstacles3()
        {
            int[,] t = { { 0, 0, 0 } };
            Assert.AreEqual(1, Ex062.UniquePathsWithObstacles(t));
        }

        [TestMethod]
        public void LeetCode_Ex062_Test_UniquePathsWithObstacles4()
        {
            int[,] t = { { 0, 1, 0 } };
            Assert.AreEqual(0, Ex062.UniquePathsWithObstacles(t));
        }

        [TestMethod]
        public void LeetCode_Ex062_Test_UniquePathsWithObstacles5()
        {
            int[,] t = { { 0, 0, 0 }, { 0, 1, 1 }, { 0, 1, 0 } };
            Assert.AreEqual(0, Ex062.UniquePathsWithObstacles(t));
        }
    };
}
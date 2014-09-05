using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex073Test
    {
        [TestMethod]
        public void LeetCode_Ex073_Test_SetZeroes1()
        {
            int [,] t = {{1, 0, 6}, {2, 1, 3}, {4, 0, 5}};
            Ex073.SetZeroes(t);
            Assert.AreEqual(0, t[0, 0]);
            Assert.AreEqual(0, t[2, 2]);
        }

        [TestMethod]
        public void LeetCode_Ex073_Test_SetZeroes2()
        {
            int [,] t = {{1, 0, 6, 1}, {2, 1, 3, 3}, {4, 0, 5, 5}};
            Ex073.SetZeroes(t);
            Assert.AreEqual(0, t[0, 0]);
            Assert.AreEqual(0, t[2, 3]);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex051Test
    {
        [TestMethod]
        public void LeetCode_Ex051_Test_TotalNQueens1()
        {
            Assert.AreEqual(2, Ex051.TotalNQueens(4));
        }

        [TestMethod]
        public void LeetCode_Ex051_Test_TotalNQueens2()
        {
            Assert.AreEqual(0, Ex051.TotalNQueens(3));
        }

        [TestMethod]
        public void LeetCode_Ex051_Test_TotalNQueens3()
        {
            Assert.AreEqual(10, Ex051.TotalNQueens(5));
        }
    };
}
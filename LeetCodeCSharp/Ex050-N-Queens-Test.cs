using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex050Test
    {
        [TestMethod]
        public void LeetCode_Ex050_Test_SolveNQueens1()
        {
            List<List<string>> res = Ex050.SolveNQueens(4);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex050_Test_SolveNQueens2()
        {
            List<List<string>> res = Ex050.SolveNQueens(2);
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex050_Test_SolveNQueens3()
        {
            List<List<string>> res = Ex050.SolveNQueens(3);
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex050_Test_SolveNQueens4()
        {
            List<List<string>> res = Ex050.SolveNQueens(5);
            Assert.AreEqual(10, res.Count);
        }
    };
}
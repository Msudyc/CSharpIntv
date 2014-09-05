using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex038Test
    {
        [TestMethod]
        public void LeetCode_Ex038_Test_CombinationSum1()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = Ex038.CombinationSum(t, 7);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex038_Test_CombinationSum2()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = Ex038.CombinationSum(t, 6);
            Assert.AreEqual(3, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex038_Test_CombinationSum3()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = Ex038.CombinationSum(t, 1);
            Assert.AreEqual(0, res.Count);
        }
    };
}
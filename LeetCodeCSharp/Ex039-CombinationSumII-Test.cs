using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex039Test
    {
        [TestMethod]
        public void LeetCode_Ex039_Test_CombinationSum2_1()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = Ex039.CombinationSum2(t, 7);
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex039_Test_CombinationSum2_2()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            List<List<int>> res = Ex039.CombinationSum2(t, 5);
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex039_Test_CombinationSum2_3()
        {
            List<int> t = new List<int>();
            t.Add(2); t.Add(3); t.Add(6); t.Add(7);
            t.Add(1); t.Add(1);
            List<List<int>> res = Ex039.CombinationSum2(t, 6);
            Assert.AreEqual(2, res.Count);
        }
    };
}
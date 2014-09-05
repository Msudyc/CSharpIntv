using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex046Test
    {
        [TestMethod]
        public void LeetCode_Ex046_Test_PermuteUnique1()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2);
            List<List<int>> res = Ex046.PermuteUnique(t);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex046_Test_PermuteUnique2()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2); t.Add(3);
            List<List<int>> res = Ex046.PermuteUnique(t);
            Assert.AreEqual(6, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex046_Test_PermuteUnique3()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2); t.Add(2);
            List<List<int>> res = Ex046.PermuteUnique(t);
            Assert.AreEqual(3, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex046_Test_PermuteUnique4()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(1);
            List<List<int>> res = Ex046.PermuteUnique(t);
            Assert.AreEqual(1, res.Count);
        }
    };
}
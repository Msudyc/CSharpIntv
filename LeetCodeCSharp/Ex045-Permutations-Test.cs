using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex045Test
    {
        [TestMethod]
        public void LeetCode_Ex045_Test_Permute1()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2);
            List<List<int>> res = Ex045.Permute(t);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex045_Test_Permute2()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2); t.Add(3);
            List<List<int>> res = Ex045.Permute(t);
            Assert.AreEqual(6, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex045_Test_Permute3()
        {
            List<int> t = new List<int>();
            t.Add(1);
            List<List<int>> res = Ex045.Permute(t);
            Assert.AreEqual(1, res.Count);
        }
    };
}
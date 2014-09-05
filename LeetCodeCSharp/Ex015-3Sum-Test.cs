using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex015Test
    {
        [TestMethod]
        public void LeetCode_Ex015_Test_ThreeSum1()
        {
            List<int> v = new List<int>();
            v.Add(-2);
            v.Add(0);
            v.Add(1);
            v.Add(1);
            v.Add(2);
            List<List<int>> r = Ex015.ThreeSum(v);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex015_Test_ThreeSum2()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(0);
            v.Add(1);
            v.Add(2);
            v.Add(-1);
            v.Add(-4);
            List<List<int>> r = Ex015.ThreeSum(v);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex015_Test_ThreeSum3()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(0);
            v.Add(1);
            v.Add(2);
            v.Add(-1);
            v.Add(-4);
            v.Add(0);
            v.Add(0);
            v.Add(0);
            v.Add(1);
            v.Add(0);
            v.Add(0);
            v.Add(0);
            List<List<int>> r = Ex015.ThreeSum(v);
            Assert.AreEqual(3, r.Count);
        }
    };
}
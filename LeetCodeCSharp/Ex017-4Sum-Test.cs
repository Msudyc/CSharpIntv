using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex017Test
    {
        [TestMethod]
        public void LeetCode_Ex017_Test_FourSum1()
        {
            List<int> v = new List<int>();
            v.Add(-2);
            v.Add(0);
            v.Add(1);
            v.Add(1);
            v.Add(2);
            List<List<int>> r = Ex017.FourSum(v, 0);
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex017_Test_FourSum2()
        {
            List<int> v = new List<int>();
            v.Add(-2);
            v.Add(0);
            v.Add(1);
            v.Add(2);
            List<List<int>> r = Ex017.FourSum(v, 0);
            Assert.AreEqual(0, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex017_Test_FourSum3()
        {
            List<int> v = new List<int>();
            v.Add(1);
            v.Add(0);
            v.Add(-1);
            v.Add(0);
            v.Add(-2);
            v.Add(2);
            List<List<int>> r = Ex017.FourSum(v, 0);
            Assert.AreEqual(3, r.Count);
        }
    };
}
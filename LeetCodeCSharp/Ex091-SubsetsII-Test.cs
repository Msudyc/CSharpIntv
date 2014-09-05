using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex091Test
    {
        [TestMethod]
        public void LeetCode_Ex091_Test_SubsetsWithDup1()
        {
            int[] row0 = {2, 2, 2, 2};
            List<int> r0 = new List<int>(row0);
            List<List<int>> r = Ex091.SubsetsWithDup(r0);
            Assert.AreEqual(5, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex091_Test_SubsetsWithDup2()
        {
            int[] row0 = {1};
            List<int> r0 = new List<int>(row0);
            List<List<int>> r = Ex091.SubsetsWithDup(r0);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex091_Test_SubsetsWithDup3()
        {
            int[] row0 = {1, 2, 2, 4, 5};
            List<int> r0 = new List<int>(row0);
            List<List<int>> r = Ex091.SubsetsWithDup(r0);
            Assert.AreEqual(24, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex091_Test_SubsetsWithDup4()
        {
            int[] row0 = {1, 2, 3};
            List<int> r0 = new List<int>(row0);
            List<List<int>> r = Ex091.SubsetsWithDup(r0);
            Assert.AreEqual(8, r.Count);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex055Test
    {
        [TestMethod]
        public void LeetCode_Ex055_Test_Merge1()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            t.Add(new Interval(1, 4));
            t.Add(new Interval(5, 7));
            List<Interval> r = Ex055.Merge(t);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex055_Test_Merge2()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            List<Interval> r = Ex055.Merge(t);
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex055_Test_Merge3()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            t.Add(new Interval(1, 4));
            t.Add(new Interval(4, 7));
            List<Interval> r = Ex055.Merge(t);
            Assert.AreEqual(1, r.Count);
        }
    };
}
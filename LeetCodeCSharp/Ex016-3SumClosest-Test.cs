using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex016Test
    {
        [TestMethod]
        public void LeetCode_Ex016_Test_ThreeSumClosest1()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(2);
            v.Add(1);
            v.Add(-4);
            Assert.AreEqual(2, Ex016.ThreeSumClosest(v, 1));
            v.Clear();
            v.Add(0);
            v.Add(2);
            v.Add(1);
            v.Add(-3);
            Assert.AreEqual(0, Ex016.ThreeSumClosest(v, 1));
        }

        [TestMethod]
        public void LeetCode_Ex016_Test_ThreeSumClosest2()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(2);
            v.Add(1);
            Assert.AreEqual(2, Ex016.ThreeSumClosest(v, 5));
        }

        [TestMethod]
        public void LeetCode_Ex016_Test_ThreeSumClosest3()
        {
            List<int> v = new List<int>();
            v.Add(-1);
            v.Add(2);
            Assert.AreEqual(0, Ex016.ThreeSumClosest(v, 5));
        }
    };
}
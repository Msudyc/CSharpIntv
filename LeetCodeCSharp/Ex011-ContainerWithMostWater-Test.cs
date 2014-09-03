using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex011Test
    {
        [TestMethod]
        public void LeetCode_Ex011_Test_MaxArea1()
        {
            List<int> t = new List<int>();
            t.Add(2);
            Assert.AreEqual(0, Ex011.MaxAreaBF(t));
            t.Add(4);
            Assert.AreEqual(2, Ex011.MaxAreaBF(t));
            t.Add(8);
            Assert.AreEqual(4, Ex011.MaxAreaBF(t));
        }

        [TestMethod]
        public void LeetCode_Ex011_Test_MaxArea2()
        {
            List<int> t = new List<int>();
            t.Add(2);
            Assert.AreEqual(0, Ex011.MaxArea(t));
            t.Add(4);
            Assert.AreEqual(2, Ex011.MaxArea(t));
            t.Add(8);
            Assert.AreEqual(4, Ex011.MaxArea(t));
        }
    };
}
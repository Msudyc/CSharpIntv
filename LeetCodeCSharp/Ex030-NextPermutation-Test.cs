using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex030Test
    {
        [TestMethod]
        public void LeetCode_Ex030_Test_NextPermutation1()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2); t.Add(3);
            Ex030.nextPermutation(t);
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(3, t[1]);
            Assert.AreEqual(2, t[2]);
        }

        [TestMethod]
        public void LeetCode_Ex030_Test_NextPermutation2()
        {
            List<int> t = new List<int>();
            t.Add(3); t.Add(2); t.Add(1);
            Ex030.nextPermutation(t);
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
            Assert.AreEqual(3, t[2]);
        }

        [TestMethod]
        public void LeetCode_Ex030_Test_NextPermutation3()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(1); t.Add(5);
            Ex030.nextPermutation(t);
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(5, t[1]);
            Assert.AreEqual(1, t[2]);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex089Test
    {
        [TestMethod]
        public void LeetCode_Ex089_Test_GrayCode1()
        {
            List<int> r = Ex089.GrayCode(2);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(1, r[1]);
            Assert.AreEqual(3, r[2]);
            Assert.AreEqual(2, r[3]);
        }

        [TestMethod]
        public void LeetCode_Ex089_Test_GrayCode2()
        {
            List<int> r = Ex089.GrayCode(1);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(1, r[1]);
        }

        [TestMethod]
        public void LeetCode_Ex089_Test_GrayCode3()
        {
            List<int> r = Ex089.GrayCode(0);
            Assert.AreEqual(0, r[0]);
        }

        [TestMethod]
        public void LeetCode_Ex089_Test_GrayCode4()
        {
            List<int> r = Ex089.GrayCode(3);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(1, r[1]);
            Assert.AreEqual(3, r[2]);
            Assert.AreEqual(2, r[3]);
            Assert.AreEqual(6, r[4]);
            Assert.AreEqual(7, r[5]);
            Assert.AreEqual(5, r[6]);
            Assert.AreEqual(4, r[7]);
        }
    };
}
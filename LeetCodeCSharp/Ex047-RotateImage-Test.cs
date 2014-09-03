using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex047Test
    {
        [TestMethod]
        public void LeetCode_Ex047_Test_Rotate1()
        {
            int[,] t = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            Ex047.Rotate(t);
            Assert.AreEqual(1, t[0, 0]);
            Assert.AreEqual(1, t[0, 1]);
            Assert.AreEqual(1, t[0, 2]);
            Assert.AreEqual(2, t[1, 0]);
            Assert.AreEqual(2, t[1, 1]);
            Assert.AreEqual(2, t[1, 2]);
            Assert.AreEqual(3, t[2, 0]);
            Assert.AreEqual(3, t[2, 1]);
            Assert.AreEqual(3, t[2, 2]);
        }

        [TestMethod]
        public void LeetCode_Ex047_Test_Rotate2()
        {
            int[,] t = { { 1, 2 }, { 1, 2 } };
            Ex047.Rotate(t);
            Assert.AreEqual(1, t[0, 0]);
            Assert.AreEqual(1, t[0, 1]);
            Assert.AreEqual(2, t[1, 0]);
            Assert.AreEqual(2, t[1, 0]);
        }
    };
}
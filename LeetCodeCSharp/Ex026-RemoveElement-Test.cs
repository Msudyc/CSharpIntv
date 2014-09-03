using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex026Test
    {
        [TestMethod]
        public void LeetCode_Ex026_Test_RemoveElement1()
        {
            int[] t = {0, 1, 3, 1, 4, 5, 1, 6};
            Assert.AreEqual(5, Ex026.RemoveElement(t, 1));
            Assert.AreEqual(0, t[0]);
            Assert.AreEqual(3, t[1]);
            Assert.AreEqual(4, t[2]);
            Assert.AreEqual(5, t[3]);
            Assert.AreEqual(6, t[4]);
        }

        [TestMethod]
        public void LeetCode_Ex026_Test_RemoveElement2()
        {
            int[] t = {0, 1, 2, 3, 4, 5, 6, 7};
            Assert.AreEqual(8, Ex026.RemoveElement(t, 9));
        }
    };
}
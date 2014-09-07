using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex119Test
    {
        [TestMethod]
        public void LeetCode_Ex119_Test_GetRow1()
        {
            List<int> r = Ex119.GetRow(3);
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(3, r[1]);
            Assert.AreEqual(3, r[2]);
            Assert.AreEqual(1, r[3]);
        }
    };
}
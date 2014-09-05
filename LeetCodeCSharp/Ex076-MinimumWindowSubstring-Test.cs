using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex076Test
    {
        [TestMethod]
        public void LeetCode_Ex076_Test_MinWindow1()
        {
            Assert.AreEqual("BANC", Ex076.MinWindow("ADOBECODEBANC", "ABC"));
        }

        [TestMethod]
        public void LeetCode_Ex076_Test_MinWindow2()
        {
            Assert.AreEqual("", Ex076.MinWindow("ABCDEFG", "XYZ"));
        }

        [TestMethod]
        public void LeetCode_Ex076_Test_MinWindow3()
        {
            Assert.AreEqual("A", Ex076.MinWindow("A", "A"));
        }

        [TestMethod]
        public void LeetCode_Ex076_Test_MinWindow4()
        {
            Assert.AreEqual("BAC", Ex076.MinWindow("GBACDEF", "BC"));
        }
    };
}
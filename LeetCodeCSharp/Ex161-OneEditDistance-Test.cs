using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex161Test
    {
        [TestMethod]
        public void LeetCode_Ex161_Test_IsOneEditDistance1()
        {
            Assert.IsTrue(Ex161.IsOneEditDistance("a", "ab"));
        }

        [TestMethod]
        public void LeetCode_Ex161_Test_IsOneEditDistance2()
        {
            Assert.IsTrue(Ex161.IsOneEditDistance("ac", "ab"));
        }

        [TestMethod]
        public void LeetCode_Ex161_Test_IsOneEditDistance3()
        {
            Assert.IsFalse(Ex161.IsOneEditDistance("a", "a"));
        }

        [TestMethod]
        public void LeetCode_Ex161_Test_IsOneEditDistance4()
        {
            Assert.IsFalse(Ex161.IsOneEditDistance("a", "abc"));
        }
    };
}
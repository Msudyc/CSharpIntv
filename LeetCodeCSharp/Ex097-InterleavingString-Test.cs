using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex097Test
    {
        [TestMethod]
        public void LeetCode_Ex097_Test_IsInterleave1()
        {
            Assert.IsTrue(Ex097.IsInterleave("ace", "bdf", "abcdef"));
        }

        [TestMethod]
        public void LeetCode_Ex097_Test_IsInterleave2()
        {
            Assert.IsFalse(Ex097.IsInterleave("ake", "bdf", "abcdef"));
        }

        [TestMethod]
        public void LeetCode_Ex097_Test_IsInterleave3()
        {
            Assert.IsTrue(Ex097.IsInterleave("a", "b", "ba"));
        }

        [TestMethod]
        public void LeetCode_Ex097_Test_IsInterleave4()
        {
            Assert.IsTrue(Ex097.IsInterleave("", "", ""));
        }

        [TestMethod]
        public void LeetCode_Ex097_Test_IsInterleave5()
        {
            Assert.IsTrue(Ex097.IsInterleave("a", "", "a"));
        }

        [TestMethod]
        public void LeetCode_Ex097_Test_IsInterleave6()
        {
            Assert.IsFalse(Ex097.IsInterleave("ab", "cd", "dcab"));
        }
    };
}
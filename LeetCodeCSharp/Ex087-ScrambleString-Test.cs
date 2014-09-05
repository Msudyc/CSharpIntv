using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex087Test
    {
        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble1()
        {
            Assert.IsTrue(Ex087.IsScramble("great", "rgaet"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble2()
        {
            Assert.IsTrue(Ex087.IsScramble("ab", "ba"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble3()
        {
            Assert.IsTrue(Ex087.IsScramble("a", "a"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble4()
        {
            Assert.IsFalse(Ex087.IsScramble("breat", "rgaet"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble5()
        {
            Assert.IsFalse(Ex087.IsScramble("b", "c"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble6()
        {
            Assert.IsTrue(Ex087.IsScramble1("great", "rgaet"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble7()
        {
            Assert.IsTrue(Ex087.IsScramble1("ab", "ba"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble8()
        {
            Assert.IsTrue(Ex087.IsScramble1("a", "a"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble9()
        {
            Assert.IsFalse(Ex087.IsScramble1("breat", "rgaet"));
        }

        [TestMethod]
        public void LeetCode_Ex087_Test_IsScramble10()
        {
            Assert.IsFalse(Ex087.IsScramble1("b", "c"));
        }
    };
}
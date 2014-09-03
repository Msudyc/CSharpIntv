using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex043Test
    {
        [TestMethod]
        public void LeetCode_Ex043_Test_IsMatch1()
        {
            Assert.IsFalse(Ex043.IsMatch("aa", "a"));
            Assert.IsTrue(Ex043.IsMatch("aa", "a*"));
        }

        [TestMethod]
        public void LeetCode_Ex043_Test_IsMatch2()
        {
            Assert.IsFalse(Ex043.IsMatch("aa", "abb"));
        }

        [TestMethod]
        public void LeetCode_Ex043_Test_IsMatch3()
        {
            Assert.IsTrue(Ex043.IsMatch("aa", "a?"));
        }

        [TestMethod]
        public void LeetCode_Ex043_Test_IsMatch4()
        {
            Assert.IsTrue(Ex043.IsMatch("aabb", "a*"));
        }

        [TestMethod]
        public void LeetCode_Ex043_Test_IsMatch5()
        {
            Assert.IsTrue(Ex043.IsMatch("aabb", "a?*"));
        }

        [TestMethod]
        public void LeetCode_Ex043_Test_IsMatch6()
        {
            Assert.IsFalse(Ex043.IsMatch("aacbb", "a*c"));
        }
    };
}
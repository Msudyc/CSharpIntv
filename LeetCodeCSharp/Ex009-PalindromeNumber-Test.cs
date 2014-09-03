using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex009Test
    {
        [TestMethod]
        public void LeetCode_Ex009_Test_IsPalindrome1()
        {
            Assert.IsTrue(Ex009.IsPalindrome(0));
            Assert.IsFalse(Ex009.IsPalindrome(-12));
            Assert.IsTrue(Ex009.IsPalindrome(121));
            Assert.IsFalse(Ex009.IsPalindrome(1123));
            Assert.IsTrue(Ex009.IsPalindrome(986121689));
            Assert.IsTrue(Ex009.IsPalindrome(1001));
            Assert.IsTrue(Ex009.IsPalindrome(1000110001));
        }

        [TestMethod]
        public void LeetCode_Ex009_Test_IsPalindrome2()
        {
            Assert.IsFalse(Ex009.IsPalindrome(10));
        }
    };
}
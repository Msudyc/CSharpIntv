using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex005Test
    {
        [TestMethod]
        public void LeetCode_Ex005_Test_LongestPalindrome1()
        {
            string s = "abbac";
            Assert.AreEqual("abba", Ex005.LongestPalindrome(s));
        }

        [TestMethod]
        public void LeetCode_Ex005_Test_LongestPalindrome2()
        {
            string s = "abbac";
            Assert.AreEqual("abba", Ex005.LongestPalindrome1(s));
        }

        [TestMethod]
        public void LeetCode_Ex005_Test_LongestPalindrome3()
        {
            string s = "abbac";
            Assert.AreEqual("abba", Ex005.LongestPalindrome2(s));
        }

        [TestMethod]
        public void LeetCode_Ex005_Test_LongestPalindrome4()
        {
            string s = "abbac";
            Assert.AreEqual("abba", Ex005.LongestPalindrome3(s));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex003Test
    {
        [TestMethod]
        public void LeetCode_Ex003_Test_LengthOfLongestSubstring1()
        {
            string a = "abcbdebc";
            Assert.AreEqual(4, Ex003.LengthOfLongestSubstring(a));
        }

        [TestMethod]
        public void LeetCode_Ex003_Test_LengthOfLongestSubstring2()
        {
            string a = "bbbbbbbb";
            Assert.AreEqual(1, Ex003.LengthOfLongestSubstring(a));
        }

        [TestMethod]
        public void LeetCode_Ex003_Test_LengthOfLongestSubstring3()
        {
            string a = "";
            Assert.AreEqual(0, Ex003.LengthOfLongestSubstring(a));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex014Test
    {
        [TestMethod]
        public void LeetCode_Ex014_Test_longestCommonPrefix()
        {
            List<string> t = new List<string>();
            t.Add("aab");
            t.Add("aabd");
            t.Add("aabe");
            Assert.AreEqual("aab", Ex014.LongestCommonPrefix(t));
        }

        [TestMethod]
        public void LeetCode_Ex014_Test_longestCommonPrefix1()
        {
            List<string> t = new List<string>();
            Assert.AreEqual("", Ex014.LongestCommonPrefix(t));
        }

        [TestMethod]
        public void LeetCode_Ex014_Test_longestCommonPrefix2()
        {
            List<string> t = new List<string>();
            t.Add("aab");
            Assert.AreEqual("aab", Ex014.LongestCommonPrefix(t));
        }

        [TestMethod]
        public void LeetCode_Ex014_Test_longestCommonPrefix3()
        {
            List<string> t = new List<string>();
            t.Add("a");
            t.Add("b");
            t.Add("aabe");
            Assert.AreEqual("", Ex014.LongestCommonPrefix(t));
        }

        [TestMethod]
        public void LeetCode_Ex014_Test_longestCommonPrefix4()
        {
            List<string> t = new List<string>();
            t.Add("aa");
            t.Add("ab");
            t.Add("aabe");
            Assert.AreEqual("a", Ex014.LongestCommonPrefix(t));
        }
    }
}
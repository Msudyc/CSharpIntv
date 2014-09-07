using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex139Test
    {
        [TestMethod]
        public void LeetCode_Ex139_Test_WordBreak1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("leet"); 
            dict.Add("code");
            Assert.IsTrue(Ex139.WordBreak("leetcode", dict));
        }

        [TestMethod]
        public void LeetCode_Ex139_Test_WordBreak2()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("leet"); 
            dict.Add("codeaa");
            Assert.IsFalse(Ex139.WordBreak("leetcode", dict));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex140Test
    {
        [TestMethod]
        public void LeetCode_Ex140_Test_WordBreak1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("cat"); 
            dict.Add("cats");
            dict.Add("and"); 
            dict.Add("sand");
            dict.Add("dog");
            List<string> r = Ex140.WordBreak("catsanddog", dict);
            Assert.AreEqual(2, r.Count);
            Assert.IsTrue(r.Contains("cat sand dog"));
            Assert.IsTrue(r.Contains("cats and dog"));
        }
    };
}
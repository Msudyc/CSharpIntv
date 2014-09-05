using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex048Test
    {
        [TestMethod]
        public void LeetCode_Ex048_Test_Anagrams1()
        {
            List<string> t = new List<string>();
            t.Add("abcd");
            t.Add("dcbd");
            t.Add("dcba");
            t.Add("fcba");
            List<string> r = Ex048.Anagrams(t);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex048_Test_Anagrams2()
        {
            List<string> t = new List<string>();
            t.Add("abc");
            t.Add("cba");
            t.Add("ad");
            t.Add("da");
            t.Add("dac");
            List<string> r = Ex048.Anagrams(t);
            Assert.AreEqual(4, r.Count);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex029Test
    {
        [TestMethod]
        public void LeetCode_Ex029_Test_FindSubstring1()
        {
            List<string> s = new List<string>();
            s.Add("bar");
            s.Add("foo");
            List<int> r = Ex029.FindSubstring("barfoothefoobarman", s);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(9, r[1]);

            s.Clear();
            r.Clear();
            s.Add("a");
            s.Add("a");
            r = Ex029.FindSubstring("aaa", s);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(1, r[1]);

            s.Clear();
            r.Clear();
            s.Add("a");
            s.Add("a");
            s.Add("b");
            r = Ex029.FindSubstring("abababab", s);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(2, r[1]);
            Assert.AreEqual(4, r[2]);
        }
    };
}
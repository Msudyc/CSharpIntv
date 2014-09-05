using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex068Test
    {
        [TestMethod]
        public void LeetCode_Ex068_Test_FullJustify1()
        {
            List<string> t = new List<string>();
            t.Add("this");
            t.Add("is");
            t.Add("a");
            t.Add("very");
            t.Add("good");
            t.Add("example");
            t.Add("of");
            t.Add("test");
            List<string> r = Ex068.FullJustify(t, 10);
            Assert.AreEqual(4, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex068_Test_FullJustify2()
        {
            List<string> t = new List<string>();
            t.Add("this");
            t.Add("is");
            t.Add("a");
            t.Add("very");
            t.Add("good");
            t.Add("example");
            t.Add("of");
            t.Add("justification");
            t.Add("you");
            t.Add("can");
            t.Add("see");
            List<string> r = Ex068.FullJustify(t, 10);
            Assert.AreEqual(6, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex068_Test_FullJustify3()
        {
            List<string> t = new List<string>();
            t.Add("this");
            t.Add("is");
            t.Add("an");
            t.Add("example");
            List<string> r = Ex068.FullJustify(t, 10);
            Assert.AreEqual(2, r.Count);
        }
    };
}
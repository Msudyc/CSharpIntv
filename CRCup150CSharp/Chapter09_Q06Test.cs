using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q06Test
    {
        [TestMethod]
        public void CRCup_CH09_06_GenerateParens1()
        {
            List<string> result = Chapter09_Q06.GenerateParens(3);
            Assert.AreEqual(5, result.Count);
            Assert.IsTrue(result.Contains("(()())"));
            Assert.IsTrue(result.Contains("((()))"));
            Assert.IsTrue(result.Contains("()(())"));
            Assert.IsTrue(result.Contains("(())()"));
            Assert.IsTrue(result.Contains("()()()"));
        }
    }
}

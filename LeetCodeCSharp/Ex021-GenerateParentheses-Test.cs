using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex021Test
    {
        [TestMethod]
        public void LeetCode_Ex021_Test_GenerateParenthesis1()
        {
            List<string> r = Ex021.GenerateParenthesis(3);
            Assert.AreEqual(5, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex021_Test_GenerateParenthesis2()
        {
            List<string> r = Ex021.GenerateParenthesis(1);
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex021_Test_GenerateParenthesis3()
        {
            List<string> r = Ex021.GenerateParenthesis(2);
            Assert.AreEqual(2, r.Count);
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex031Test
    {
        [TestMethod]
        public void LeetCode_Ex031_Test_LongestValidParentheses1()
        {
            Assert.AreEqual(4, Ex031.LongestValidParentheses(")()())"));
            Assert.AreEqual(2, Ex031.LongestValidParentheses("()"));
            Assert.AreEqual(2, Ex031.LongestValidParentheses("()(()"));
        }

        [TestMethod]
        public void LeetCode_Ex031_Test_LongestValidParentheses2()
        {
            Assert.AreEqual(0, Ex031.LongestValidParentheses(""));
            Assert.AreEqual(0, Ex031.LongestValidParentheses("("));
            Assert.AreEqual(0, Ex031.LongestValidParentheses(")"));
        }
    };
}
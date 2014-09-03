using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex020Test
    {
        [TestMethod]
        public void LeetCode_Ex020_Test_IsValid1()
        {
            string s = "()[]{}", s2 ="([)]";
            Assert.IsTrue(Ex020.IsValid(s));
            Assert.IsFalse(Ex020.IsValid(s2));
        }

        [TestMethod]
        public void LeetCode_Ex020_Test_IsValid2()
        {
            string s = "", s2 ="(()]";
            Assert.IsTrue(Ex020.IsValid(s));
            Assert.IsFalse(Ex020.IsValid(s2));
        }

        [TestMethod]
        public void LeetCode_Ex020_Test_IsValid3()
        {
            string s = "(((())))[{()}]", s2 ="(((())))[{(}]";
            Assert.IsTrue(Ex020.IsValid(s));
            Assert.IsFalse(Ex020.IsValid(s2));
        }
    };
}
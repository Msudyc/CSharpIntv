using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex125Test
    {
        [TestMethod]
        public void LeetCode_Ex125_Test_IsPalindrome1()
        {
            Assert.IsTrue(Ex125.IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [TestMethod]
        public void LeetCode_Ex125_Test_IsPalindrome2()
        {
            Assert.IsFalse(Ex125.IsPalindrome("A man, a plan, a canalc: Panama"));
        }

        [TestMethod]
        public void LeetCode_Ex125_Test_IsPalindrome3()
        {
            Assert.IsTrue(Ex125.IsPalindrome("   "));
        }

        [TestMethod]
        public void LeetCode_Ex125_Test_IsPalindrome4()
        {
            Assert.IsTrue(Ex125.IsPalindrome(" c "));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex151Test
    {
        [TestMethod]
        public void LeetCode_Ex151_Test_ReverseWords1()
        {
            string s = "the sky is blue";
            string es = "blue is sky the";
            Assert.AreEqual(es, Ex151.ReverseWords(s));
        }
    };
}
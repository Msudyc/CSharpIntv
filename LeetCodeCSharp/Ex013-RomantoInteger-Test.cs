using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex013Test
    {
        [TestMethod]
        public void LeetCode_Ex013_Test_RomanToInt1()
        {
            Assert.AreEqual(138, Ex013.RomanToInt("CXXXVIII"));
            Assert.AreEqual(1996, Ex013.RomanToInt("MCMXCVI"));
        }
    };
}
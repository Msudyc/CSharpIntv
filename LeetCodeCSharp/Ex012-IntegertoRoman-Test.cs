using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex012Test
    {
        [TestMethod]
        public void LeetCode_Ex012_Test_IntToRoman1()
        {
            Assert.AreEqual("IV", Ex012.IntToRoman(4));
            Assert.AreEqual("VIII", Ex012.IntToRoman(8));
            Assert.AreEqual("CXXXVIII", Ex012.IntToRoman(138));
        }
    };
}
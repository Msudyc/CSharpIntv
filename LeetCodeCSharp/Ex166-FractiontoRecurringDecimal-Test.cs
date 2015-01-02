using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex166Test
    {
        [TestMethod]
        public void LeetCode_Ex166_Test_FractionToDecimal1()
        {
            Assert.AreEqual("0.5", Ex166.FractionToDecimal(1, 2));
        }

        [TestMethod]
        public void LeetCode_Ex166_Test_FractionToDecimal2()
        {
            Assert.AreEqual("1.(3)", Ex166.FractionToDecimal(4, 3));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex172Test
    {
        [TestMethod]
        public void LeetCode_Ex172_Test_TrailingZeroes1()
        {
            Assert.AreEqual(6, Ex172.TrailingZeroes(26));
        }
    };
}
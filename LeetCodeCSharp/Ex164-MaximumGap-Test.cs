using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex164Test
    {
        [TestMethod]
        public void LeetCode_Ex164_Test_MaximumGap1()
        {
            int[] test = { 2, 3, 1, 5, 7, 6, 11, 4, 6, 13, 15 };
            Assert.AreEqual(4, Ex164.MaximumGap(test));
        }
    };
}
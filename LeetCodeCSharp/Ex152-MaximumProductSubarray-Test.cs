using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex152Test
    {
        [TestMethod]
        public void LeetCode_Ex152_Test_MaxProduct1()
        {
            int[] A = { 2, 3, -2, 4 };
            Assert.AreEqual(6, Ex152.MaxProduct(A));
        }
    };
}
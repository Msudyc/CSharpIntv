using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex153Test
    {
        [TestMethod]
        public void LeetCode_Ex153_Test_FindMin1()
        {
            int[] num = { 4, 5, 6, 7, 0, 1, 2 };
            Assert.AreEqual(0, Ex153.FindMin(num));
        }
    };
}
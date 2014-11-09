using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex154Test
    {
        [TestMethod]
        public void LeetCode_Ex154_Test_FindMin1()
        {
            int[] num = { 4, 5, 5, 6, 7, 8, 0, 1, 1, 2 };
            Assert.AreEqual(0, Ex154.FindMin(num));
        }
    };
}
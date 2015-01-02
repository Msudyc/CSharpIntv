using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex169Test
    {
        [TestMethod]
        public void LeetCode_Ex169_Test_MajorityElement1()
        {
            int[] test = {1, 2, 3, 5, 3, 3, 2, 3, 1, 3, 3, 3, 4, 3, 1};
            Assert.AreEqual(3, Ex169.MajorityElement(test));
        }
    };
}
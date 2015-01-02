using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex162Test
    {
        [TestMethod]
        public void LeetCode_Ex162_Test_FindPeakElement1()
        {
            int[] test = { 1, 2, 3, 1 };
            Assert.AreEqual(2, Ex162.FindPeakElement(test));
        }

        [TestMethod]
        public void LeetCode_Ex162_Test_FindPeakElement2()
        {
            int[] test = { 1, 2, 3, 4 };
            Assert.AreEqual(3, Ex162.FindPeakElement(test));
        }

        [TestMethod]
        public void LeetCode_Ex162_Test_FindPeakElement3()
        {
            int[] test = { 5, 3, 3, 1 };
            Assert.AreEqual(0, Ex162.FindPeakElement(test));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex163Test
    {
        [TestMethod]
        public void LeetCode_Ex163_Test_FindMissingRanges1()
        {
            int[] test = { 0, 1, 3, 50, 75 };
            List<string> result = Ex163.FindMissingRanges(test, 0, 99);
            Assert.AreEqual("2", result[0]);
            Assert.AreEqual("4->49", result[1]);
            Assert.AreEqual("51->74", result[2]);
            Assert.AreEqual("76->99", result[3]);
        }
    };
}
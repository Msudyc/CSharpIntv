using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex040Test
    {
        [TestMethod]
        public void LeetCode_Ex040_Test_FirstMissingPositive1()
        {
            int[] A = {0, -1, -5, 4, 3, 7, 9, 1};
            Assert.AreEqual(2, Ex040.FirstMissingPositive(A));
        }

        [TestMethod]
        public void LeetCode_Ex040_Test_FirstMissingPositive2()
        {
            int[] A = {0, 2, -5, 4, 3, 7, 9, 1};
            Assert.AreEqual(5, Ex040.FirstMissingPositive(A));
        }

        [TestMethod]
        public void LeetCode_Ex040_Test_FirstMissingPositive3()
        {
            int[] A = {0};
            Assert.AreEqual(1, Ex040.FirstMissingPositive(A));
        }

        [TestMethod]
        public void LeetCode_Ex040_Test_FirstMissingPositive4()
        {
            int[] A = {0, 1, 2, 3, 4, 5};
            Assert.AreEqual(6, Ex040.FirstMissingPositive(A));
        }
    };
}
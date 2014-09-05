using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex052Test
    {
        [TestMethod]
        public void LeetCode_Ex052_Test_MaxSubArray1()
        {
            int[] A = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.AreEqual(6, Ex052.MaxSubArray(A, 9));
        }

        [TestMethod]
        public void LeetCode_Ex052_Test_MaxSubArray2()
        {
            int[] A = { -2, 1, 1, 4, -1 };
            Assert.AreEqual(6, Ex052.MaxSubArray(A, 5));
        }

        [TestMethod]
        public void LeetCode_Ex052_Test_MaxSubArray3()
        {
            int[] A = { -2, 1, 1, 4, -1, 6 };
            Assert.AreEqual(11, Ex052.MaxSubArray(A, 6));
        }

        [TestMethod]
        public void LeetCode_Ex052_Test_MaxSubArray4()
        {
            int[] A = { 0, 1, 1, 4, 1, 6 };
            Assert.AreEqual(13, Ex052.MaxSubArray(A, 6));
        }

        [TestMethod]
        public void LeetCode_Ex052_Test_MaxSubArray5()
        {
            int[] A = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.AreEqual(6, Ex052.MaxSubArrayDV(A, 9));
        }

        [TestMethod]
        public void LeetCode_Ex052_Test_MaxSubArray6()
        {
            int[] A = { -2, 1, 1, 4, -1 };
            Assert.AreEqual(6, Ex052.MaxSubArrayDV(A, 5));
        }

        [TestMethod]
        public void LeetCode_Ex052_Test_MaxSubArray7()
        {
            int[] A = { -2, 1, 1, 4, -1, 6 };
            Assert.AreEqual(11, Ex052.MaxSubArrayDV(A, 6));
        }

        [TestMethod]
        public void LeetCode_Ex052_Test_MaxSubArray8()
        {
            int[] A = { 0, 1, 1, 4, 1, 6 };
            Assert.AreEqual(13, Ex052.MaxSubArrayDV(A, 6));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex137Test
    {
        [TestMethod]
        public void LeetCode_Ex137_Test_SingleNumber1()
        {
            int[] t = { 1, 3, 2, 3, 2, 1, 4, 2, 1, 3 };
            Assert.AreEqual(4, Ex137.SingleNumber(t));
        }

        [TestMethod]
        public void LeetCode_Ex137_Test_SingleNumber2()
        {
            int[] t = { 1 };
            Assert.AreEqual(1, Ex137.SingleNumber(t));
        }

        [TestMethod]
        public void LeetCode_Ex137_Test_SingleNumber3()
        {
            int[] t = { 1, 3, 2, 3, 2, 1, 4, 2, 1, 3 };
            Assert.AreEqual(4, Ex137.SingleNumberA(t));
        }

        [TestMethod]
        public void LeetCode_Ex137_Test_SingleNumber4()
        {
            int[] t = { 1 };
            Assert.AreEqual(1, Ex137.SingleNumberA(t));
        }
    };
}
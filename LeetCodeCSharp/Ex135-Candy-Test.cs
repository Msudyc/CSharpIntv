using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex135Test
    {
        [TestMethod]
        public void LeetCode_Ex135_Test_Candy1()
        {
            int[] rating = { 1, 4, 1, 2 };
            Assert.AreEqual(6, Ex135.Candy(rating));
        }

        [TestMethod]
        public void LeetCode_Ex135_Test_Candy2()
        {
            int[] rating = { 1, 4 };
            Assert.AreEqual(3, Ex135.Candy(rating));
        }

        [TestMethod]
        public void LeetCode_Ex135_Test_Candy3()
        {
            int[] rating = { 1 };
            Assert.AreEqual(1, Ex135.Candy(rating));
        }
    };
}
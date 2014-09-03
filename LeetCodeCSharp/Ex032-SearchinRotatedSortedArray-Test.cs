using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex032Test
    {
        [TestMethod]
        public void LeetCode_Ex032_Test_Search1()
        {
            int[] t = {4,5,6,7,0,1,2};
            Assert.AreEqual(5, Ex032.Search(t, 1));
        }

        [TestMethod]
        public void LeetCode_Ex032_Test_Search2()
        {
            int[] t = {4,5,6,7,0,1,2};
            Assert.AreEqual(-1, Ex032.Search(t, 9));
        }

        [TestMethod]
        public void LeetCode_Ex032_Test_Search3()
        {
            int[] t = {4};
            Assert.AreEqual(-1, Ex032.Search(t, 9));
        }

        [TestMethod]
        public void LeetCode_Ex032_Test_Search4()
        {
            int[] t = {0};
            Assert.AreEqual(-1, Ex032.Search(t, 9));
        }
    };
}
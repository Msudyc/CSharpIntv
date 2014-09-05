using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex072Test
    {
        [TestMethod]
        public void LeetCode_Ex072_Test_MinDistance1()
        {
            Assert.AreEqual(3, Ex072.MinDistance("ok", "good"));
        }

        [TestMethod]
        public void LeetCode_Ex072_Test_MinDistance2()
        {
            Assert.AreEqual(2, Ex072.MinDistance("gok", "good"));
        }

        [TestMethod]
        public void LeetCode_Ex072_Test_MinDistance3()
        {
            Assert.AreEqual(3, Ex072.MinDistance("gok", ""));
        }

        [TestMethod]
        public void LeetCode_Ex072_Test_MinDistance4()
        {
            Assert.AreEqual(0, Ex072.MinDistance("good", "good"));
        }
    };
}
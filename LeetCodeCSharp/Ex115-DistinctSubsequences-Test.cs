using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex115Test
    {
        [TestMethod]
        public void LeetCode_Ex115_Test_NumDistinct1()
        {
            Assert.AreEqual(3, Ex115.NumDistinct("rabbbit", "rabbit"));
        }

        [TestMethod]
        public void LeetCode_Ex115_Test_NumDistinct2()
        {
            Assert.AreEqual(2, Ex115.NumDistinct("aab", "a"));
        }

        [TestMethod]
        public void LeetCode_Ex115_Test_NumDistinct3()
        {
            Assert.AreEqual(1, Ex115.NumDistinct("rabbitk", "rabbit"));
        }
    };
}
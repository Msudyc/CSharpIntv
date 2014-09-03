using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex007Test
    {
        [TestMethod]
        public void LeetCode_Ex007_Test_Reverse1()
        {
            Assert.AreEqual(0, Ex007.Reverse(0));
            Assert.AreEqual(2, Ex007.Reverse(2));
            Assert.AreEqual(-2, Ex007.Reverse(-2));
            Assert.AreEqual(123, Ex007.Reverse(321));
            Assert.AreEqual(-123, Ex007.Reverse(-321));
            Assert.AreEqual(1, Ex007.Reverse(100));
        }
    };
}
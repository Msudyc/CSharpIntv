using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex028Test
    {
        [TestMethod]
        public void LeetCode_Ex028_Test_Divide1()
        {
            Assert.AreEqual(3, Ex028.Divide(7, 2));
            Assert.AreEqual(4, Ex028.Divide(12, 3));
            Assert.AreEqual(-1, Ex028.Divide(1, -1));
            Assert.AreEqual(9, Ex028.Divide(29, 3));
        }
    };
}
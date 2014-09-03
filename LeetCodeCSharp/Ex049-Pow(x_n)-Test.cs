using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex049Test
    {
        [TestMethod]
        public void LeetCode_Ex049_Test_Pow1()
        {
            Assert.AreEqual(8.0, Ex049.Pow(2.0, 3));
        }

        [TestMethod]
        public void LeetCode_Ex049_Test_Pow2()
        {
            Assert.AreEqual(1.0, Ex049.Pow(1.0, 3));
        }

        [TestMethod]
        public void LeetCode_Ex049_Test_Pow3()
        {
            Assert.AreEqual(16.0, Ex049.Pow(2.0, 4));
        }
    };
}
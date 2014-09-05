using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex069Test
    {
        [TestMethod]
        public void LeetCode_Ex069_Test_Sqrt1()
        {
            Assert.AreEqual(7, Ex069.Sqrt(49));
        }

        [TestMethod]
        public void LeetCode_Ex069_Test_Sqrt2()
        {
            Assert.AreEqual(1, Ex069.Sqrt(1));
        }

        [TestMethod]
        public void LeetCode_Ex069_Test_Sqrt3()
        {
            Assert.AreEqual(10, Ex069.Sqrt(100));
        }

        [TestMethod]
        public void LeetCode_Ex069_Test_Sqrt4()
        {
            Assert.AreEqual(5, Ex069.Sqrt(25));
        }
    };
}
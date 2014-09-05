using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex066Test
    {
        [TestMethod]
        public void LeetCode_Ex066_Test_IsNumber1()
        {
            Assert.IsFalse(Ex066.IsNumber("aaa"));
        }

        [TestMethod]
        public void LeetCode_Ex066_Test_IsNumber2()
        {
            Assert.IsTrue(Ex066.IsNumber("110.1123"));
        }

        [TestMethod]
        public void LeetCode_Ex066_Test_IsNumber3()
        {
            Assert.IsFalse(Ex066.IsNumber("10a"));
        }

        [TestMethod]
        public void LeetCode_Ex066_Test_IsNumber4()
        {
            Assert.IsTrue(Ex066.IsNumber("001.e3"));
        }

        [TestMethod]
        public void LeetCode_Ex066_Test_IsNumber5()
        {
            Assert.IsFalse(Ex066.IsNumber("1e345.1123"));
        }
    };
}
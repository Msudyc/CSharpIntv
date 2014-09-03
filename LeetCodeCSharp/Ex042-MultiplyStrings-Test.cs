using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex042Test
    {
        [TestMethod]
        public void LeetCode_Ex042_Test_Multiply1()
        {
            Assert.AreEqual("56088", Ex042.Multiply("123", "456"));
        }

        [TestMethod]
        public void LeetCode_Ex042_Test_Multiply2()
        {
            Assert.AreEqual("0", Ex042.Multiply("0", "45623456432"));
        }

        [TestMethod]
        public void LeetCode_Ex042_Test_Multiply3()
        {
            Assert.AreEqual("55597647977088", Ex042.Multiply("1232123", "45123456"));
        }
    };
}
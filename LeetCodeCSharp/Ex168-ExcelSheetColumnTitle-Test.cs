using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex168Test
    {
        [TestMethod]
        public void LeetCode_Ex168_Test_ConvertToTitle1()
        {
            Assert.AreEqual("AB", Ex168.ConvertToTitle(28));
        }
    };
}
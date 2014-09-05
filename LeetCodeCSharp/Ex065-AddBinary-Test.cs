using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex065Test
    {
        [TestMethod]
        public void LeetCode_Ex065_Test_AddBinary1()
        {
            Assert.AreEqual("101010110", Ex065.AddBinary("11111111", "1010111"));
        }

        [TestMethod]
        public void LeetCode_Ex065_Test_AddBinary2()
        {
            Assert.AreEqual("10", Ex065.AddBinary("1", "1"));
        }

        [TestMethod]
        public void LeetCode_Ex065_Test_AddBinary3()
        {
            Assert.AreEqual("0", Ex065.AddBinary("0", "0"));
        }

        [TestMethod]
        public void LeetCode_Ex065_Test_AddBinary4()
        {
            Assert.AreEqual("1", Ex065.AddBinary("1", "0"));
        }
    };
}
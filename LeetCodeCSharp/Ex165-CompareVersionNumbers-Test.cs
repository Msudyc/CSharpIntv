using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex165Test
    {
        [TestMethod]
        public void LeetCode_Ex165_Test_CompareVersion1()
        {
            Assert.AreEqual(-1, Ex165.CompareVersion("2.3.4", "2.3.67"));
        }

        [TestMethod]
        public void LeetCode_Ex165_Test_CompareVersion2()
        {
            Assert.AreEqual(0, Ex165.CompareVersion("2.3", "2.3.0.0"));
        }

        [TestMethod]
        public void LeetCode_Ex165_Test_CompareVersion3()
        {
            Assert.AreEqual(1, Ex165.CompareVersion("2.6", "2.3.0.0"));
        }
    };
}
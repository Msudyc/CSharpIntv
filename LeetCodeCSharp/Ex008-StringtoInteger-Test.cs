using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex008Test
    {
        [TestMethod]
        public void LeetCode_Ex008_Test_Atoi1()
        {
            Assert.AreEqual(1234, Ex008.Atoi("1234"));
            Assert.AreEqual(-1234, Ex008.Atoi("-1234"));
            Assert.AreEqual(-1234, Ex008.Atoi("    -1234"));
            Assert.AreEqual(0, Ex008.Atoi("aaa-1234"));
            Assert.AreEqual(int.MaxValue, Ex008.Atoi("2147483648"));
            Assert.AreEqual(int.MinValue, Ex008.Atoi("-2147483649"));
            Assert.AreEqual(int.MaxValue, Ex008.Atoi("    10522545459"));
            Assert.AreEqual(int.MinValue, Ex008.Atoi("      -11919730356x"));
        }
    };
}
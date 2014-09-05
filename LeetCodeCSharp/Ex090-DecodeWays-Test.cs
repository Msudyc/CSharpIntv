using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex090Test
    {
        [TestMethod]
        public void LeetCode_Ex090_Test_NumDecodings1()
        {
            Assert.AreEqual(2, Ex090.NumDecodings("12"));
        }

        [TestMethod]
        public void LeetCode_Ex090_Test_NumDecodings2()
        {
            Assert.AreEqual(3, Ex090.NumDecodings("123"));
        }

        [TestMethod]
        public void LeetCode_Ex090_Test_NumDecodings3()
        {
            Assert.AreEqual(1, Ex090.NumDecodings("5"));
        }

        [TestMethod]
        public void LeetCode_Ex090_Test_NumDecodings4()
        {
            Assert.AreEqual(1, Ex090.NumDecodings("567"));
        }

        [TestMethod]
        public void LeetCode_Ex090_Test_NumDecodings5()
        {
            Assert.AreEqual(2, Ex090.NumDecodings("2343"));
        }
    };
}
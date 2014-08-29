using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter01_Q05Test
    {
        [TestMethod]
        public void CRCup_CH01_05_Compress1()
        {
            Assert.AreEqual("a2b5c1", Chapter01_Q05.Compress("aabbbbbc"));
        }

        [TestMethod]
        public void CRCup_CH01_05_Compress2()
        {
            Assert.AreEqual("abcdeff", Chapter01_Q05.Compress("abcdeff"));
        }
    }
}

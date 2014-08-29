using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter05_Q06Test
    {
        [TestMethod]
        public void CRCup_CH05_06_SwapOddEvenBits1()
        {
            Assert.AreEqual((uint)1, Chapter05_Q06.SwapOddEvenBits(2));
        }

        [TestMethod]
        public void CRCup_CH05_06_SwapOddEvenBits2()
        {
            Assert.AreEqual((uint)0x55555555, Chapter05_Q06.SwapOddEvenBits(0xaaaaaaaa));
        }
    }
}

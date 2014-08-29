using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter05_Q01Test
    {
        [TestMethod]
        public void CRCup_CH05_01_UpdateBits1()
        {
            int n = 0x400;
            int m = 0x13;
            int i = 2;
            int j = 6;
            Assert.AreEqual(0x44C, Chapter05_Q01.UpdateBits(n, m, i, j));
        }
    }
}

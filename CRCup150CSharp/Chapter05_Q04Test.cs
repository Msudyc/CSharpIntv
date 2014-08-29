using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter05_Q04Test
    {
        [TestMethod]
        public void CRCup_CH05_04_CheckPowerOfTwo1()
        {
            Assert.AreEqual(0, 8 & (8 - 1));
        }

        [TestMethod]
        public void CRCup_CH05_04_CheckPowerOfTwo2()
        {
            Assert.AreEqual(0, 16 & (16 - 1));
        }

        [TestMethod]
        public void CRCup_CH05_04_CheckPowerOfTwo3()
        {
            Assert.AreNotEqual(0, 15 & (15 - 1));
        }
    }
}

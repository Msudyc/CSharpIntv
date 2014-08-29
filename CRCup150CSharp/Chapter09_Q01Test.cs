using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q01Test
    {
        [TestMethod]
        public void CRCup_CH09_01_CountWaysDP1()
        {
            Assert.AreEqual(7, Chapter09_Q01.CountWaysDP(4));
        }

        [TestMethod]
        public void CRCup_CH09_01_CountWaysDP2()
        {
            Assert.AreEqual(274, Chapter09_Q01.CountWaysDP(10));
        }

        [TestMethod]
        public void CRCup_CH09_01_CountWaysDP3()
        {
            Assert.AreEqual(4, Chapter09_Q01.CountWaysDP(3));
        }
    }
}

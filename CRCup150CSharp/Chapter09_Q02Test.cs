using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q02Test
    {
        [TestMethod]
        public void CRCup_CH09_02_GetPathsNumDP1()
        {
            Assert.AreEqual(2, Chapter09_Q02.GetPathsNumDP(1, 1));
        }

        [TestMethod]
        public void CRCup_CH09_02_GetPathsNumDP2()
        {
            Assert.AreEqual(3, Chapter09_Q02.GetPathsNumDP(1, 2));
        }

        [TestMethod]
        public void CRCup_CH09_02_GetPathsNumDP3()
        {
            Assert.AreEqual(184756, Chapter09_Q02.GetPathsNumDP(10, 10));
        }
    }
}

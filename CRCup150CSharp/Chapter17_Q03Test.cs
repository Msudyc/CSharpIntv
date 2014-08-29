using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q03Test
    {
        [TestMethod]
        public void CRCup_CH17_03_CountFactZeros1()
        {
            Assert.AreEqual(1, Chapter17_Q03.CountFactZeros(6));
        }

        [TestMethod]
        public void CRCup_CH17_03_CountFactZeros2()
        {
            Assert.AreEqual(7, Chapter17_Q03.CountFactZeros(30));
        }
    }
}

using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q04Test
    {
        [TestMethod]
        public void CRCup_CH17_04_GetMax1()
        {
            Assert.AreEqual(7, Chapter17_Q04.GetMax(6, 7));
        }

        [TestMethod]
        public void CRCup_CH17_04_GetMax2()
        {
            Assert.AreEqual(6, Chapter17_Q04.GetMax(6, -7));
        }

        [TestMethod]
        public void CRCup_CH17_04_GetMax3()
        {
            Assert.AreEqual(int.MaxValue - 2, Chapter17_Q04.GetMax(int.MaxValue - 2, -7));
        }
    }
}

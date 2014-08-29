using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter07_Q07Test
    {
        [TestMethod]
        public void CRCup_CH07_07_GetKthMagicNumber1()
        {
            Assert.AreEqual(21, Chapter07_Q07.GetKthMagicNumber(6));
        }

        [TestMethod]
        public void CRCup_CH07_07_GetKthMagicNumber2()
        {
            Assert.AreEqual(27, Chapter07_Q07.GetKthMagicNumber(8));
        }
    }
}

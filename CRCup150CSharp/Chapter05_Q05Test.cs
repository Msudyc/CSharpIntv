using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter05_Q05Test
    {
        [TestMethod]
        public void CRCup_CH05_05_BitSwapRequired1()
        {
            Assert.AreEqual(2, Chapter05_Q05.BitSwapRequired(31, 14));
        }
    }
}

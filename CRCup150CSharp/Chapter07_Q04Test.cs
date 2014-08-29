using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter07_Q04Test
    {
        [TestMethod]
        public void CRCup_CH07_04_Minus1()
        {
            Assert.AreEqual(3, Chapter07_Q04.Minus(8, 5));
        }

        [TestMethod]
        public void CRCup_CH07_04_Multiply1()
        {
            Assert.AreEqual(40, Chapter07_Q04.Multiply(8, 5));
        }

        [TestMethod]
        public void CRCup_CH07_04_Divide1()
        {
            Assert.AreEqual(3, Chapter07_Q04.Divide(30, 10));
        }
    }
}

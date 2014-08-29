using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q01Test
    {
        [TestMethod]
        public void CRCup_CH18_01_Add1()
        {
            Assert.AreEqual(1023, Chapter18_Q01.Add(345, 678));
        }
    }
}

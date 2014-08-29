using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter05_Q02Test
    {
        [TestMethod]
        public void CRCup_CH05_02_PrintBinary1()
        {
            Assert.AreEqual(".101", Chapter05_Q02.PrintBinary(0.625));
        }

        [TestMethod]
        public void CRCup_CH05_02_PrintBinary2()
        {
            Assert.AreEqual("ERROR", Chapter05_Q02.PrintBinary(1.625));
        }

        [TestMethod]
        public void CRCup_CH05_02_PrintBinary3()
        {
            Assert.AreEqual("ERROR", Chapter05_Q02.PrintBinary(0.0001));
        }
    }
}

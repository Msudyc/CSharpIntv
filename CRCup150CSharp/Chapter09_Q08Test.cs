using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q08Test
    {
        [TestMethod]
        public void CRCup_CH09_08_MakeChange1()
        {
            Assert.AreEqual(242, Chapter09_Q08.MakeChange(100));
        }

        [TestMethod]
        public void CRCup_CH09_08_MakeChange2()
        {
            Assert.AreEqual(1, Chapter09_Q08.MakeChange(1));
        }

        [TestMethod]
        public void CRCup_CH09_08_MakeChange3()
        {
            Assert.AreEqual(4, Chapter09_Q08.MakeChange(10));
        }
    }
}

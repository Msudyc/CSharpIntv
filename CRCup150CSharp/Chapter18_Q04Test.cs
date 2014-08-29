using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q04Test
    {
        [TestMethod]
        public void CRCup_CH18_04_Count2sInRange1()
        {
            Assert.AreEqual(6, Chapter18_Q04.Count2sInRange(22));
        }

        [TestMethod]
        public void CRCup_CH18_04_Count2sInRange2()
        {
            Assert.AreEqual(9, Chapter18_Q04.Count2sInRange(25));
        }
    }
}

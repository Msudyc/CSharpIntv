using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q05Test
    {
        [TestMethod]
        public void CRCup_CH17_05_Estimate1()
        {
            Chapter17_Q05.Result result = Chapter17_Q05.Estimate("GGRR", "RGBY");
            Assert.AreEqual(1, result.Hits);
            Assert.AreEqual(1, result.PseudoHits);
        }

        [TestMethod]
        public void CRCup_CH17_05_Estimate2()
        {
            Chapter17_Q05.Result result = Chapter17_Q05.Estimate("RGRR", "RGBY");
            Assert.AreEqual(2, result.Hits);
            Assert.AreEqual(0, result.PseudoHits);
        }
    }
}

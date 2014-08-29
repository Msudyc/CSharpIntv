using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter05_Q03Test
    {
        [TestMethod]
        public void CRCup_CH05_03_GetNext1()
        {
            Assert.AreEqual(13, Chapter05_Q03.GetNext(11));
        }

        [TestMethod]
        public void CRCup_CH05_03_GetNext2()
        {
            Assert.AreEqual(17, Chapter05_Q03.GetNext(12));
        }

        [TestMethod]
        public void CRCup_CH05_03_GetPre1()
        {
            Assert.AreEqual(11, Chapter05_Q03.GetPre(13));
        }

        [TestMethod]
        public void CRCup_CH05_03_GetPre2()
        {
            Assert.AreEqual(12, Chapter05_Q03.GetPre(17));
        }
    }
}

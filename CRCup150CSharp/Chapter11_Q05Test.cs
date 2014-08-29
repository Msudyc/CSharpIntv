using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter11_Q05Test
    {
        [TestMethod]
        public void CRCup_CH11_05_Search1()
        {
            string[] array = { "at", "", "", "", "ball", "", "", "car", "", "", "dad", "", "" };
            Assert.AreEqual(4, Chapter11_Q05.Search(array, "ball"));
        }

        [TestMethod]
        public void CRCup_CH11_05_Search2()
        {
            string[] array = { "at", "", "", "", "ball", "", "", "car", "", "", "dad", "", "" };
            Assert.AreEqual(7, Chapter11_Q05.Search(array, "car"));
        }
    }
}

using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter11_Q03Test
    {
        [TestMethod]
        public void CRCup_CH11_03_Search1()
        {
            int[] array = { 15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14 };
            Assert.AreEqual(8, Chapter11_Q03.Search(array, 5));
        }

        [TestMethod]
        public void CRCup_CH11_03_Search2()
        {
            int[] array = { 15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14 };
            Assert.AreEqual(10, Chapter11_Q03.Search(array, 10));
        }

        [TestMethod]
        public void CRCup_CH11_03_Search3()
        {
            int[] array = { 15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14 };
            Assert.AreEqual(0, Chapter11_Q03.Search(array, 15));
        }
    }
}

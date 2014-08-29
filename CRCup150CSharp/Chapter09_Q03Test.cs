using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q03Test
    {
        [TestMethod]
        public void CRCup_CH09_03_MagicFast1()
        {
            int[] arr = { -40, -20, -1, 1, 2, 3, 5, 7, 9, 12, 13 };
            Assert.AreEqual(7, Chapter09_Q03.MagicFast(arr));
        }

        [TestMethod]
        public void CRCup_CH09_03_MagicFastNotDistinct1()
        {
            int[] arr = { -10, -5, 2, 2, 2, 3, 4, 6, 9, 12, 13 };
            Assert.AreEqual(2, Chapter09_Q03.MagicFastNotDistinct(arr));
        }
    }
}

using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q03Test
    {
        [TestMethod]
        public void CRCup_CH18_03_PickMRandomly1()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] result = Chapter18_Q03.PickMRandomly(array, 4);
            Assert.AreNotEqual(1, result[0]);
            Assert.AreNotEqual(2, result[1]);
            Assert.AreNotEqual(3, result[2]);
            Assert.AreNotEqual(4, result[3]);
        }
    }
}

using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter01_Q07Test
    {
        [TestMethod]
        public void CRCup_CH01_07_SetZeros1()
        {
            int[,] test = new int[2, 2] { { 1, 2 }, { 0, 3 } };
            Chapter01_Q07.SetZeros(test);
            Assert.AreEqual(0, test[0, 0]);
            Assert.AreEqual(2, test[0, 1]);
            Assert.AreEqual(0, test[1, 0]);
            Assert.AreEqual(0, test[1, 1]);
        }

        [TestMethod]
        public void CRCup_CH01_07_SetZeros2()
        {
            int[,] test = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Chapter01_Q07.SetZeros(test);
            Assert.AreEqual(1, test[0, 0]);
            Assert.AreEqual(2, test[0, 1]);
            Assert.AreEqual(3, test[1, 0]);
            Assert.AreEqual(4, test[1, 1]);
        }
    }
}

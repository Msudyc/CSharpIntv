using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter01_Q06Test
    {
        [TestMethod]
        public void CRCup_CH01_06_Rotate1()
        {
            int[,] test = new int[2,2] { { 1, 2 }, { 4, 3 } };
            Chapter01_Q06.Rotate(test, 2);
            Assert.AreEqual(4, test[0, 0]);
            Assert.AreEqual(1, test[0, 1]);
            Assert.AreEqual(3, test[1, 0]);
            Assert.AreEqual(2, test[1, 1]);
        }
    }
}

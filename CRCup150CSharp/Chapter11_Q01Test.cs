using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter11_Q01Test
    {
        [TestMethod]
        public void CRCup_CH11_01_Merge1()
        {
            int[] a = new int[12] { 1, 3, 5, 7, 9, 0, 0, 0, 0, 0, 0, 0 };
            int[] b = { 2, 4, 6, 8, 10, 12 };
            Chapter11_Q01.Merge(a, b, 5);
            Assert.AreEqual(1, a[0]);
            Assert.AreEqual(2, a[1]);
            Assert.AreEqual(3, a[2]);
            Assert.AreEqual(4, a[3]);
            Assert.AreEqual(5, a[4]);
            Assert.AreEqual(6, a[5]);
            Assert.AreEqual(7, a[6]);
            Assert.AreEqual(8, a[7]);
            Assert.AreEqual(9, a[8]);
            Assert.AreEqual(10, a[9]);
            Assert.AreEqual(12, a[10]);
        }
    }
}

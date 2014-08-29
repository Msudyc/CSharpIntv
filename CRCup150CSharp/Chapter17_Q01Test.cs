using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q01Test
    {
        [TestMethod]
        public void CRCup_CH17_01_Swap1()
        {
            int a = 5, b= 6;
            Chapter17_Q01.Swap(ref a, ref b);
            Assert.AreEqual(6, a);
            Assert.AreEqual(5, b);
        }
    }
}

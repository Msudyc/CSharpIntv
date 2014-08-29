using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q08Test
    {
        [TestMethod]
        public void CRCup_CH17_08_GetMaxSum1()
        {
            int[] test = { 2, -8, 3, -2, 4, -10 };
            Assert.AreEqual(5, Chapter17_Q08.GetMaxSum(test));
        }
    }
}

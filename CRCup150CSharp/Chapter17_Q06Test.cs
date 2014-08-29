using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q06Test
    {
        [TestMethod]
        public void CRCup_CH17_06_Find1()
        {
            int[] test = { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 };
            Tuple<int, int> result = Chapter17_Q06.Find(test);
            Assert.AreEqual(3, result.Item1);
            Assert.AreEqual(9, result.Item2);
        }
    }
}

using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q12Test
    {
        [TestMethod]
        public void CRCup_CH17_12_GetPairSums1()
        {
            int[] test = {2, 7, 4, 1, 5, 9, 10, 3, 8, 11, 0, 6};
            List<Tuple<int, int>> result = Chapter17_Q12.GetPairSums1(test, 11);
            Assert.AreEqual(6, result.Count);
        }

        [TestMethod]
        public void CRCup_CH17_12_GetPairSums2()
        {
            int[] test = { 2, 7, 4, 1, 5, 9, 10, 3, 8, 11, 0, 6 };
            List<Tuple<int, int>> result = Chapter17_Q12.GetPairSums2(test, 11);
            Assert.AreEqual(6, result.Count);
        }
    }
}

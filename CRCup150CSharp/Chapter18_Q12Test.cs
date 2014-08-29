using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q12Test
    {
        [TestMethod]
        public void CRCup_CH18_12_GetMaxMatric1()
        {
            int[,] test = {{1, -2, 1},
                           {-3,  1, 2},
                           {-1,  2, 1}};
            Assert.AreEqual(6, Chapter18_Q12.GetMaxMatric(test));
        }

        [TestMethod]
        public void CRCup_CH18_12_GetMaxMatric2()
        {
            int[,] test = {{1, -2, 1, 0},
                           {-3,  1, 2, -3},
                           {-1,  2, 3, -4},
                           {-2,  2, 1, 1}};
            Assert.AreEqual(11, Chapter18_Q12.GetMaxMatric(test));
        }
    }
}

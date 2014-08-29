using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter11_Q06Test
    {
        [TestMethod]
        public void CRCup_CH11_06_FindElement1()
        {
            int[,] arr = {{1, 2, 3, 4},
                          {5, 6, 7, 8},
                          {10, 11,12,13}};
            Assert.IsTrue(Chapter11_Q06.FindElement(arr, 10));
        }

        [TestMethod]
        public void CRCup_CH11_06_FindElement2()
        {
            int[,] arr = {{1, 2, 3, 4},
                          {5, 6, 7, 8},
                          {10, 11,12,13}};
            Assert.IsFalse(Chapter11_Q06.FindElement(arr, 9));
        }
    }
}

using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q11Test
    {
        [TestMethod]
        public void CRCup_CH18_11_FindSquare1()
        {
            int[,] test = {{1, 0, 1, 1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0, 0, 0, 0},
                           {1, 0, 1, 0, 0, 0, 0, 1},
                           {0, 0, 1, 1, 0, 0, 1, 0},
                           {1, 0, 1, 1, 0, 0, 0, 1},
                           {0, 0, 0, 0, 0, 0, 0, 0},
                           {1, 1, 0, 1, 0, 0, 1, 0},
                           {1, 0, 1, 1, 0, 0, 0, 0}};
            Chapter18_Q11.SubSquare result = Chapter18_Q11.FindSquare(test);
            Assert.AreEqual(1, result.Row);
            Assert.AreEqual(1, result.Col);
            Assert.AreEqual(5, result.Size);
        }
    }
}

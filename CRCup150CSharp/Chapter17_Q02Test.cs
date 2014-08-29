using System;
using CRCup150CSharp;
using P = CRCup150CSharp.Chapter17_Q02.Piece;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q02Test
    {
        [TestMethod]
        public void CRCup_CH17_02_HasWon1()
        {
            P[,] board = { {P.Blue, P.Blue, P.Red},
                           {P.Red, P.Red, P.Blue},
                           {P.Red, P.Blue, P.Blue}};
            Assert.AreEqual(P.Red, Chapter17_Q02.HasWon(board));
        }

        [TestMethod]
        public void CRCup_CH17_02_HasWon2()
        {
            P[,] board = { {P.Blue, P.Blue, P.Empty},
                           {P.Red, P.Red, P.Blue},
                           {P.Red, P.Blue, P.Blue}};
            Assert.AreEqual(P.Empty, Chapter17_Q02.HasWon(board));
        }
    }
}

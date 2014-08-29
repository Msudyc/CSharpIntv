using System;
using CRCup150CSharp;
using C = CRCup150CSharp.Chapter09_Q07.Color;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q07Test
    {
        [TestMethod]
        public void CRCup_CH09_07_PaintFill1()
        {
            C[,] screen = {{C.Black, C.Black, C.Black, C.Red},
                           {C.Black, C.Red, C.Black, C.Red},
                           {C.Black, C.Yellow, C.Black, C.Red}};
            Chapter09_Q07.PaintFill(screen, 1, 2, C.White);
            Assert.AreEqual(C.White, screen[0, 0]);
            Assert.AreEqual(C.White, screen[0, 1]);
            Assert.AreEqual(C.White, screen[0, 2]);
            Assert.AreEqual(C.Red, screen[0, 3]);
            Assert.AreEqual(C.White, screen[1, 0]);
            Assert.AreEqual(C.Red, screen[1, 1]);
            Assert.AreEqual(C.White, screen[1, 2]);
            Assert.AreEqual(C.Red, screen[1, 3]);
            Assert.AreEqual(C.White, screen[2, 0]);
            Assert.AreEqual(C.Yellow, screen[2, 1]);
            Assert.AreEqual(C.White, screen[2, 2]);
            Assert.AreEqual(C.Red, screen[2, 3]);
        }
    }
}

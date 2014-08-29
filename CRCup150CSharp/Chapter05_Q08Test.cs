using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter05_Q08Test
    {
        [TestMethod]
        public void CRCup_CH05_08_Drawline1()
        {
            int width = 32;
            byte[] screen = new byte[(width / 8) * 4];
            Chapter05_Q08.Drawline(screen, width, 3, 19, 1);
            Assert.AreEqual(0x1f, screen[4]);
            Assert.AreEqual(0xff, screen[5]);
            Assert.AreEqual(0xf0, screen[6]);
        }
    }
}

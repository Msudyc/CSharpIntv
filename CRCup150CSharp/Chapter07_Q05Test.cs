using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter07_Q05Test
    {
        [TestMethod]
        public void CRCup_CH07_05_Cut1()
        {
            Chapter07_Q05.SpecialSquare sq1 = new Chapter07_Q05.SpecialSquare()
            {
                TopLeft = new Chapter07_Q05.Point(4, 4),
                Length = 2
            };

            Chapter07_Q05.SpecialSquare sq2 = new Chapter07_Q05.SpecialSquare()
            {
                TopLeft = new Chapter07_Q05.Point(5, 5),
                Length = 4
            };

            Chapter07_Q05.Line line = sq1.Cut(sq2);
            Assert.AreEqual(5, line.Start.X);
            Assert.AreEqual(5, line.Start.Y);
            Assert.AreEqual(7, line.End.X);
            Assert.AreEqual(7, line.End.Y);                
        }
    }
}

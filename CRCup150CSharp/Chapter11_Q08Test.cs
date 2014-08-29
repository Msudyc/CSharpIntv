using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter11_Q08Test
    {
        [TestMethod]
        public void CRCup_CH11_08_GetRank1()
        {
            Chapter11_Q08.Track(5);
            Chapter11_Q08.Track(1);
            Chapter11_Q08.Track(4);
            Chapter11_Q08.Track(4);
            Chapter11_Q08.Track(5);
            Chapter11_Q08.Track(9);
            Chapter11_Q08.Track(7);
            Chapter11_Q08.Track(13);
            Chapter11_Q08.Track(3);

            Assert.AreEqual(0, Chapter11_Q08.GetRankOfNumber(1));
            Assert.AreEqual(1, Chapter11_Q08.GetRankOfNumber(3));
            Assert.AreEqual(3, Chapter11_Q08.GetRankOfNumber(4));
        }
    }
}

using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter07_Q06Test
    {
        [TestMethod]
        public void CRCup_CH07_06_FindBestLine1()
        {
            List<Chapter07_Q06.Point> points = new List<Chapter07_Q06.Point>();
            points.Add(new Chapter07_Q06.Point(1, 2));
            points.Add(new Chapter07_Q06.Point(2, 3));
            points.Add(new Chapter07_Q06.Point(3, 4));
            points.Add(new Chapter07_Q06.Point(4, 9));

            Chapter07_Q06.Line result = Chapter07_Q06.FindBestLine(points);
            Assert.AreEqual(1.0, result.Slope);
            Assert.AreEqual(1.0, result.YIntercept);
            Assert.IsFalse(result.InfiniteSlope);
        }
    }
}

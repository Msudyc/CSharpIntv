using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q10Test
    {
        [TestMethod]
        public void CRCup_CH09_10_CreateStackDP1()
        {
            Chapter09_Q10.Box b1 = new Chapter09_Q10.Box(1, 1, 1);
            Chapter09_Q10.Box b2 = new Chapter09_Q10.Box(3, 3, 3);
            Chapter09_Q10.Box b3 = new Chapter09_Q10.Box(6, 6, 6);
            Chapter09_Q10.Box b4 = new Chapter09_Q10.Box(9, 9, 9);
            Chapter09_Q10.Box b5 = new Chapter09_Q10.Box(1, 6, 3);
            Chapter09_Q10.Box b6 = new Chapter09_Q10.Box(7, 1, 2);

            List<Chapter09_Q10.Box> boxes = new List<Chapter09_Q10.Box>();
            boxes.Add(b1);
            boxes.Add(b2);
            boxes.Add(b3);
            boxes.Add(b4);
            boxes.Add(b5);
            boxes.Add(b6);

            List<Chapter09_Q10.Box> result = Chapter09_Q10.CreateStackDP(boxes);
            Assert.AreEqual(4, result.Count);

            Assert.AreEqual(1, result[0].Depth);
            Assert.AreEqual(1, result[0].Width);
            Assert.AreEqual(1, result[0].Height);

            Assert.AreEqual(3, result[1].Depth);
            Assert.AreEqual(3, result[1].Width);
            Assert.AreEqual(3, result[1].Height);

            Assert.AreEqual(6, result[2].Depth);
            Assert.AreEqual(6, result[2].Width);
            Assert.AreEqual(6, result[2].Height);

            Assert.AreEqual(9, result[3].Depth);
            Assert.AreEqual(9, result[3].Width);
            Assert.AreEqual(9, result[3].Height);

        }

        [TestMethod]
        public void CRCup_CH09_10_CreateStackDP2()
        {
            Chapter09_Q10.Box b1 = new Chapter09_Q10.Box(1, 1, 1);
            Chapter09_Q10.Box b2 = new Chapter09_Q10.Box(3, 3, 3);
            Chapter09_Q10.Box b3 = new Chapter09_Q10.Box(6, 6, 6);
            Chapter09_Q10.Box b4 = new Chapter09_Q10.Box(9, 9, 9);
            Chapter09_Q10.Box b5 = new Chapter09_Q10.Box(1, 6, 3);
            Chapter09_Q10.Box b6 = new Chapter09_Q10.Box(7, 1, 2);
            Chapter09_Q10.Box b7 = new Chapter09_Q10.Box(12, 12, 12);
            Chapter09_Q10.Box b8 = new Chapter09_Q10.Box(4, 9, 1);

            List<Chapter09_Q10.Box> boxes = new List<Chapter09_Q10.Box>();
            boxes.Add(b1);
            boxes.Add(b2);
            boxes.Add(b3);
            boxes.Add(b4);
            boxes.Add(b5);
            boxes.Add(b6);
            boxes.Add(b7);
            boxes.Add(b8);

            List<Chapter09_Q10.Box> result = Chapter09_Q10.CreateStackDP(boxes);
            Assert.AreEqual(5, result.Count);

            Assert.AreEqual(1, result[0].Depth);
            Assert.AreEqual(1, result[0].Width);
            Assert.AreEqual(1, result[0].Height);

            Assert.AreEqual(3, result[1].Depth);
            Assert.AreEqual(3, result[1].Width);
            Assert.AreEqual(3, result[1].Height);

            Assert.AreEqual(6, result[2].Depth);
            Assert.AreEqual(6, result[2].Width);
            Assert.AreEqual(6, result[2].Height);

            Assert.AreEqual(9, result[3].Depth);
            Assert.AreEqual(9, result[3].Width);
            Assert.AreEqual(9, result[3].Height);

            Assert.AreEqual(12, result[4].Depth);
            Assert.AreEqual(12, result[4].Width);
            Assert.AreEqual(12, result[4].Height);
        }
    }
}

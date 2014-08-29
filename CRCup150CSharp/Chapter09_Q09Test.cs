using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q09Test
    {
        [TestMethod]
        public void CRCup_CH09_09_PlaceQueues1()
        {
            List<int[]> result = Chapter09_Q09.PlaceQueues(4);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void CRCup_CH09_09_PlaceQueues2()
        {
            List<int[]> result = Chapter09_Q09.PlaceQueues(5);
            Assert.AreEqual(10, result.Count);
        }

        [TestMethod]
        public void CRCup_CH09_09_PlaceQueues3()
        {
            List<int[]> result = Chapter09_Q09.PlaceQueues(3);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void CRCup_CH09_09_PlaceQueues4()
        {
            List<int[]> result = Chapter09_Q09.PlaceQueues(8);
            Assert.AreEqual(92, result.Count);
        }
    }
}

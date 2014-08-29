using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q04Test
    {
        [TestMethod]
        public void CRCup_CH09_04_GetAllSubSets1()
        {
            int[] arr = { 1, 2, 3 };
            List<List<int>> result = Chapter09_Q04.GetAllSubSets(arr);
            Assert.AreEqual(8, result.Count);
            Assert.AreEqual(0, result[0].Count);
            Assert.AreEqual(1, result[1][0]);
            Assert.AreEqual(2, result[2][0]);
            Assert.AreEqual(1, result[3][0]);
            Assert.AreEqual(2, result[3][1]);
            Assert.AreEqual(3, result[4][0]);
            Assert.AreEqual(1, result[5][0]);
            Assert.AreEqual(3, result[5][1]);
            Assert.AreEqual(2, result[6][0]);
            Assert.AreEqual(3, result[6][1]);
            Assert.AreEqual(1, result[7][0]);
            Assert.AreEqual(2, result[7][1]);
            Assert.AreEqual(3, result[7][2]);
        }
    }
}

using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q11Test
    {
        [TestMethod]
        public void CRCup_CH09_11_NumOfWaysDP1()
        {
            Assert.AreEqual(3, Chapter09_Q11.NumOfWays("1^0|0|1", true));
        }

        [TestMethod]
        public void CRCup_CH09_11_NumOfWaysDP2()
        {
            Assert.AreEqual(1, Chapter09_Q11.NumOfWays("1^0", true));
        }

        [TestMethod]
        public void CRCup_CH09_11_NumOfWaysDP3()
        {
            Assert.AreEqual(0, Chapter09_Q11.NumOfWays("1^1", true));
        }

        [TestMethod]
        public void CRCup_CH09_11_NumOfWaysDP4()
        {
            Assert.AreEqual(1, Chapter09_Q11.NumOfWays("1|0", true));
        }

        [TestMethod]
        public void CRCup_CH09_11_NumOfWaysDP5()
        {
            Assert.AreEqual(0, Chapter09_Q11.NumOfWays("0|0|0^1|0", false));
        }

        [TestMethod]
        public void CRCup_CH09_11_NumOfWaysDP6()
        {
            Assert.AreEqual(2, Chapter09_Q11.NumOfWays("1^0|0", true));
        }
    }
}

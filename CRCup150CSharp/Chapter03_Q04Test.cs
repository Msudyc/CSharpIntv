using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter03_Q04Test
    {
        [TestMethod]
        public void CRCup_CH03_04_MoveDisks1()
        {
            Chapter03_Q04.Tower[] towers = new Chapter03_Q04.Tower[3];
            for (int i = 0; i < 3; i++)
                towers[i] = new Chapter03_Q04.Tower();
            for (int i = 9; i > 0; i--)
                towers[0].Add(i);

            towers[0].MoveDisks(9, towers[2], towers[1]);

            Assert.IsTrue(towers[0].IsEmpty());
            Assert.IsTrue(towers[1].IsEmpty());
            
            Assert.AreEqual(1, towers[2].Pop());
            Assert.AreEqual(2, towers[2].Pop());
            Assert.AreEqual(3, towers[2].Pop());
            Assert.AreEqual(4, towers[2].Pop());
            Assert.AreEqual(5, towers[2].Pop());
            Assert.AreEqual(6, towers[2].Pop());
            Assert.AreEqual(7, towers[2].Pop());
            Assert.AreEqual(8, towers[2].Pop());
            Assert.AreEqual(9, towers[2].Pop());
            Assert.IsTrue(towers[2].IsEmpty());
        }
    }
}

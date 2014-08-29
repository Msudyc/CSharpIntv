using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q02Test
    {
        [TestMethod]
        public void CRCup_CH18_02_ShuffleArray1()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Chapter18_Q02.ShuffleArray(array);
            //Assert.AreNotEqual(1, array[0]);
            //Assert.AreNotEqual(2, array[1]);
            //Assert.AreNotEqual(3, array[2]);
            //Assert.AreNotEqual(4, array[3]);
            //Assert.AreNotEqual(5, array[4]);
            //Assert.AreNotEqual(6, array[5]);
            //Assert.AreNotEqual(7, array[6]);
            //Assert.AreNotEqual(8, array[7]);
            //Assert.AreNotEqual(9, array[8]);
        }
    }
}

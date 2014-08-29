using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q09Test
    {
        [TestMethod]
        public void CRCup_CH18_09_GetMedian1()
        {
            Chapter18_Q09 test = new Chapter18_Q09();
            test.AddNewNumber(3);
            test.AddNewNumber(7);
            test.AddNewNumber(2);
            test.AddNewNumber(5);
            test.AddNewNumber(9);
            test.AddNewNumber(1);
            test.AddNewNumber(4);
            test.AddNewNumber(6);
            test.AddNewNumber(8);
            Assert.AreEqual(5.0, test.GetMedian());
            test.AddNewNumber(10);
            Assert.AreEqual(5.5, test.GetMedian());
        }
    }
}

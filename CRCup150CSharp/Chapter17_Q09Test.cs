using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q09Test
    {
        [TestMethod]
        public void CRCup_CH17_09_GetFrequency1()
        {
            string[] test = { "This", "is", "just", "a", "test", "it", "is", "great" };
            Chapter17_Q09.Setup(test);
            Assert.AreEqual(1, Chapter17_Q09.GetFrequency("This"));
            Assert.AreEqual(2, Chapter17_Q09.GetFrequency("is"));
            Assert.AreEqual(0, Chapter17_Q09.GetFrequency("good"));
        }
    }
}

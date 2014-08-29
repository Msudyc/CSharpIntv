using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q07Test
    {
        [TestMethod]
        public void CRCup_CH17_07_NumToString1()
        {
            string str = Chapter17_Q07.NumToString(-123456789);
            Assert.AreEqual(
                "negative one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine", 
                str.TrimEnd());
        }
    }
}

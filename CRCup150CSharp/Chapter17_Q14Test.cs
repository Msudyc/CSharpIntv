using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q14Test
    {
        [TestMethod]
        public void CRCup_CH17_14_Parse1()
        {
            string[] dict = { "looked", "just", "like", "her", "brother" };
            string s = "therbrother";
            Chapter17_Q14 test = new Chapter17_Q14(dict, s);
            string result = test.Parse();
            Assert.AreEqual(
                "T her brother",
                result.TrimEnd());
        }
    }
}

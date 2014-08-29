using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q10Test
    {
        [TestMethod]
        public void CRCup_CH18_10_Transform1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("DAMP");
            dict.Add("LIMP");
            dict.Add("LIKE");
            dict.Add("LIME");
            dict.Add("LAMP");
            dict.Add("PASP");
            List<string> result = Chapter18_Q10.Transform("DAMP", "LIKE", dict);
            Assert.AreEqual("LIKE", result[0]);
            Assert.AreEqual("LIME", result[1]);
            Assert.AreEqual("LIMP", result[2]);
            Assert.AreEqual("LAMP", result[3]);
            Assert.AreEqual("DAMP", result[4]);
        }
    }
}

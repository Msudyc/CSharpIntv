using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter09_Q05Test
    {
        [TestMethod]
        public void CRCup_CH09_05_GetPerms1()
        {            
            List<string> result = Chapter09_Q05.GetPerms("abc");
            Assert.AreEqual(6, result.Count);

            Assert.IsTrue(result.Contains("abc"));
            Assert.IsTrue(result.Contains("bca"));
            Assert.IsTrue(result.Contains("bac"));
            Assert.IsTrue(result.Contains("cab"));
            Assert.IsTrue(result.Contains("cba"));
            Assert.IsTrue(result.Contains("acb"));
        }
    }
}

using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q13Test
    {
        [TestMethod]
        public void CRCup_CH18_13_MakeRectangle1()
        {
            string[] arr = {"dog", "cat", "dc", "oa", "gt", "tt"};
            Chapter18_Q13 test = new Chapter18_Q13(arr);
            Chapter18_Q13.Rectangle result = test.MakeRectangle();
            Assert.IsNotNull(result);
            Assert.AreEqual("dog", result.GetColumn(0));
            Assert.AreEqual("cat", result.GetColumn(1));
        }
    }
}

using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter11_Q02Test
    {
        [TestMethod]
        public void CRCup_CH11_02_Sort1()
        {
            string[] arr = { "abc", "cdb", "bac", "cab", "dbc" };
            Chapter11_Q02.Sort(arr);
            Assert.AreEqual("abc", arr[0]);
            Assert.AreEqual("bac", arr[1]);
            Assert.AreEqual("cab", arr[2]);
            Assert.AreEqual("cdb", arr[3]);
            Assert.AreEqual("dbc", arr[4]);
        }
    }
}

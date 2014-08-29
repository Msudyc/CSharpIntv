using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q08Test
    {
        [TestMethod]
        public void CRCup_CH18_08_SuffixTree1()
        {
            string testString = "mississippi"; 
            string[] stringList = {"is", "sip", "hi", "sis"};
            Chapter18_Q08.SuffixTree tree = new Chapter18_Q08.SuffixTree(testString);
            
            List<int> list = tree.Search("is");
            Assert.IsNotNull(list);

            list = tree.Search("sip");
            Assert.IsNotNull(list);

            list = tree.Search("hi");
            Assert.IsNull(list);

            list = tree.Search("sis");
            Assert.IsNotNull(list);
        }
    }
}

using System;
using CRCup150CSharp;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q10Test
    {
        [TestMethod]
        public void CRCup_CH17_10_EncodeToString1()
        {
            XElement root = new XElement(
                "family",
                new XAttribute("lastname", "AAA"),
                new XAttribute("state", "CA"),
                new XElement(
                    "person",
                    new XAttribute("firstname", "BBB"),
                    "Message"));
            string result = Chapter17_Q10.EncodeToString(root);
        }
    }
}

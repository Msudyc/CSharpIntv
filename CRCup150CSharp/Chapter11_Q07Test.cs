using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter11_Q07Test
    {
        [TestMethod]
        public void CRCup_CH11_07_CreateStackDP1()
        {
            List<Chapter11_Q07.Person> people = new List<Chapter11_Q07.Person>();
            people.Add(new Chapter11_Q07.Person(65, 100));
            people.Add(new Chapter11_Q07.Person(70, 150));
            people.Add(new Chapter11_Q07.Person(56, 90));
            people.Add(new Chapter11_Q07.Person(75, 190));
            people.Add(new Chapter11_Q07.Person(60, 95));
            people.Add(new Chapter11_Q07.Person(68, 110));

            List<Chapter11_Q07.Person> result = Chapter11_Q07.CreateStackDP(people);
            Assert.AreEqual(56, result[0].Height);
            Assert.AreEqual(90, result[0].Weight);

            Assert.AreEqual(60, result[1].Height);
            Assert.AreEqual(95, result[1].Weight);

            Assert.AreEqual(65, result[2].Height);
            Assert.AreEqual(100, result[2].Weight);

            Assert.AreEqual(68, result[3].Height);
            Assert.AreEqual(110, result[3].Weight);

            Assert.AreEqual(70, result[4].Height);
            Assert.AreEqual(150, result[4].Weight);

            Assert.AreEqual(75, result[5].Height);
            Assert.AreEqual(190, result[5].Weight);
        }
    }
}

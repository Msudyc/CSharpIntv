using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter05_Q07Test
    {
        [TestMethod]
        public void CRCup_CH05_07_FindMissing1()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 };
            List<int> input = new List<int>(arr);
            Assert.AreEqual(15, Chapter05_Q07.FindMissing(input));
        }

        [TestMethod]
        public void CRCup_CH05_07_FindMissing2()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<int> input = new List<int>(arr);
            Assert.AreEqual(12, Chapter05_Q07.FindMissing(input));
        }

        [TestMethod]
        public void CRCup_CH05_07_FindMissing3()
        {            
            List<int> input = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                if (i != 1234)
                    input.Add(i);
            }

            Assert.AreEqual(1234, Chapter05_Q07.FindMissing(input));
        }

        [TestMethod]
        public void CRCup_CH05_07_FindMissing4()
        {
            List<int> input = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                if (i != 123456)
                    input.Add(i);
            }

            Assert.AreEqual(123456, Chapter05_Q07.FindMissing(input));
        }
    }
}

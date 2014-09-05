using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex078Test
    {
        [TestMethod]
        public void LeetCode_Ex078_Test_Subsets1()
        {
            List<int> t = new List<int>();
            t.Add(1);
            t.Add(2);
            t.Add(3);
            List<List<int>> ret = Ex078.Subsets(t);
            Assert.AreEqual(8, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex078_Test_Subsets2()
        {
            List<int> t = new List<int>();
            List<List<int>> ret = Ex078.Subsets(t);
            Assert.AreEqual(1, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex078_Test_Subsets3()
        {
            List<int> t = new List<int>();
            t.Add(1);
            List<List<int>> ret = Ex078.Subsets(t);
            Assert.AreEqual(2, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex078_Test_Subsets4()
        {
            List<int> t = new List<int>();
            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(4);
            List<List<int>> ret = Ex078.Subsets(t);
            Assert.AreEqual(16, ret.Count);
        }
    };
}
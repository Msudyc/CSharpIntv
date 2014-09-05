using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex088Test
    {
        [TestMethod]
        public void LeetCode_Ex088_Test_Merge1()
        {
            int[] t1 = {1,3,5,7,9, 0, 0, 0, 0, 0, 0};
            int[] t2 = {2,4,6,8,10};
            Ex088.Merge(t1, 5, t2, 5);
            Assert.AreEqual(1, t1[0]);
            Assert.AreEqual(2, t1[1]);
            Assert.AreEqual(3, t1[2]);
            Assert.AreEqual(4, t1[3]);
            Assert.AreEqual(5, t1[4]);
            Assert.AreEqual(6, t1[5]);
            Assert.AreEqual(7, t1[6]);
            Assert.AreEqual(8, t1[7]);
            Assert.AreEqual(9, t1[8]);
            Assert.AreEqual(10, t1[9]);
        }

        [TestMethod]
        public void LeetCode_Ex088_Test_Merge2()
        {
            int[] t1 = {1,3, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            int[] t2 = {2};
            Ex088.Merge(t1, 2, t2, 1);
            Assert.AreEqual(1, t1[0]);
            Assert.AreEqual(2, t1[1]);
            Assert.AreEqual(3, t1[2]);
        }

        [TestMethod]
        public void LeetCode_Ex088_Test_Merge3()
        {
            int[] t1 = {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            int[] t2 = {2};
            Ex088.Merge(t1, 1, t2, 1);
            Assert.AreEqual(1, t1[0]);
            Assert.AreEqual(2, t1[1]);
        }

        [TestMethod]
        public void LeetCode_Ex088_Test_Merge4()
        {
            int[] t1 = {1,3,5,7,9, 0, 0, 0, 0, 0, 0};
            int[] t2 = {};
            Ex088.Merge(t1, 5, t2, 0);
            Assert.AreEqual(1, t1[0]);
            Assert.AreEqual(3, t1[1]);
            Assert.AreEqual(5, t1[2]);
            Assert.AreEqual(7, t1[3]);
            Assert.AreEqual(9, t1[4]);
        }

        [TestMethod]
        public void LeetCode_Ex088_Test_Merge5()
        {
            int[] t1 = {0, 0, 0, 0, 0, 0, 0, 0};
            int[] t2 = {2,4,6,8,10};
            Ex088.Merge(t1, 0, t2, 5);
            Assert.AreEqual(2, t1[0]);
            Assert.AreEqual(4, t1[1]);
            Assert.AreEqual(6, t1[2]);
            Assert.AreEqual(8, t1[3]);
            Assert.AreEqual(10, t1[4]);
        }
    };
}
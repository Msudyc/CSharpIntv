using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter04_Q09Test
    {
        [TestMethod]
        public void CRCup_CH04_09_FindSum1()
        {
            TreeNode<int> n0 = new TreeNode<int>(3);
            TreeNode<int> n1 = new TreeNode<int>(5);
            TreeNode<int> n2 = new TreeNode<int>(4);
            TreeNode<int> n3 = new TreeNode<int>(-1);
            TreeNode<int> n4 = new TreeNode<int>(6);
            TreeNode<int> n5 = new TreeNode<int>(1);
            TreeNode<int> n6 = new TreeNode<int>(8);
            TreeNode<int> n7 = new TreeNode<int>(1);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            n3.Right = n7;

            List<List<TreeNode<int>>> result = Chapter04_Q09.FindSum(n0, 8);
            Assert.AreEqual(4, result.Count);

            Assert.AreEqual(3, result[0][0].Data);
            Assert.AreEqual(5, result[0][1].Data);

            Assert.AreEqual(3, result[1][0].Data);
            Assert.AreEqual(5, result[1][1].Data);
            Assert.AreEqual(-1, result[1][2].Data);
            Assert.AreEqual(1, result[1][3].Data);

            Assert.AreEqual(3, result[2][0].Data);
            Assert.AreEqual(4, result[2][1].Data);
            Assert.AreEqual(1, result[2][2].Data);

            Assert.AreEqual(8, result[3][0].Data);
        }
    }
}

using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter04_Q04Test
    {
        [TestMethod]
        public void CRCup_CH04_04_CreateLevelLinkedList1()
        {
            TreeNode<int> n0 = new TreeNode<int>(0);
            TreeNode<int> n1 = new TreeNode<int>(1);
            TreeNode<int> n2 = new TreeNode<int>(2);
            TreeNode<int> n3 = new TreeNode<int>(3);
            TreeNode<int> n4 = new TreeNode<int>(4);
            TreeNode<int> n5 = new TreeNode<int>(5);
            TreeNode<int> n6 = new TreeNode<int>(6);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            List<LinkedList<TreeNode<int>>> result = Chapter04_Q04.CreateLevelLinkedList<int>(n0);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].Count);
            Assert.AreEqual(2, result[1].Count);
            Assert.AreEqual(4, result[2].Count);

            Assert.AreEqual(0, result[0].First.Value.Data);

            Assert.AreEqual(1, result[1].First.Value.Data);
            Assert.AreEqual(2, result[1].Last.Value.Data);
        }
    }
}

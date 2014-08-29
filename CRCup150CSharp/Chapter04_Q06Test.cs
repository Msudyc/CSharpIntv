using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter04_Q06Test
    {
        [TestMethod]
        public void CRCup_CH04_06_InOrderSucc1()
        {
            TreeNode<int> n0 = new TreeNode<int>(0);
            TreeNode<int> n1 = new TreeNode<int>(1);
            TreeNode<int> n2 = new TreeNode<int>(2);
            TreeNode<int> n3 = new TreeNode<int>(3);
            TreeNode<int> n4 = new TreeNode<int>(4);
            TreeNode<int> n5 = new TreeNode<int>(5);
            TreeNode<int> n6 = new TreeNode<int>(6);
            TreeNode<int> n7 = new TreeNode<int>(7);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;
            n1.Parent = n0;

            n2.Left = n5;
            n2.Right = n6;
            n2.Parent = n0;

            n3.Parent = n1;
            n4.Parent = n1;
            n5.Parent = n2;
            n6.Parent = n2;
            n3.Left = n7;
            n7.Parent = n3;

            TreeNode<int> result = Chapter04_Q06.InOrderSucc<int>(n4);
            Assert.AreEqual(0, result.Data);
        }

        [TestMethod]
        public void CRCup_CH04_06_InOrderSucc2()
        {
            TreeNode<int> n0 = new TreeNode<int>(0);
            TreeNode<int> n1 = new TreeNode<int>(1);
            TreeNode<int> n2 = new TreeNode<int>(2);
            TreeNode<int> n3 = new TreeNode<int>(3);
            TreeNode<int> n4 = new TreeNode<int>(4);
            TreeNode<int> n5 = new TreeNode<int>(5);
            TreeNode<int> n6 = new TreeNode<int>(6);
            TreeNode<int> n7 = new TreeNode<int>(7);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;
            n1.Parent = n0;

            n2.Left = n5;
            n2.Right = n6;
            n2.Parent = n0;

            n3.Parent = n1;
            n4.Parent = n1;
            n5.Parent = n2;
            n6.Parent = n2;
            n3.Left = n7;
            n7.Parent = n3;

            TreeNode<int> result = Chapter04_Q06.InOrderSucc<int>(n0);
            Assert.AreEqual(5, result.Data);
        }
    }
}

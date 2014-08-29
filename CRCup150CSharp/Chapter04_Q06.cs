/* Question 4.6
 
Write an algorithm to find the 'next' node (i.e. in-order successor) of a 
given node in a binary search tree. you may assume that each node has a 
link to its parent. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q06
    {
        public static TreeNode<T> InOrderSucc<T>(TreeNode<T> node)
        {
            if (node == null)
                return null;

            if (node.Parent == null || node.Right != null)
                return LeftMostChild(node.Right);
            else
            {
                TreeNode<T> q = node;
                TreeNode<T> x = q.Parent;
                while (x != null && x.Left != q)
                {
                    q = x;
                    x = x.Parent;
                }

                return x;
            }
        }

        private static TreeNode<T> LeftMostChild<T>(TreeNode<T> node)
        {
            if (node == null)
                return null;

            while (node.Left != null)
                node = node.Left;

            return node;
        }
    }
}

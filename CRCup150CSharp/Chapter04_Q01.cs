/* Question 4.1
 
Implement a function to check if a binary tree is balanced. For the purposes of this question,
a balanced tree is defined to be a tree such that the heights of the two subtrees of any node 
never differ by more than one.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q01
    {
        public static bool IsBalanced<T>(TreeNode<T> root)
        {
            return CheckHeight<T>(root) != -1;
        }

        private static int CheckHeight<T>(TreeNode<T> root)
        {
            if (root == null)
                return 0;
            int leftHeight = CheckHeight<T>(root.Left);
            if (leftHeight == -1)
                return -1;
            int rightHeight = CheckHeight<T>(root.Right);
            if (rightHeight == -1)
                return -1;

            if (Math.Abs(leftHeight - rightHeight) > 1)
                return -1;
            else
                return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}

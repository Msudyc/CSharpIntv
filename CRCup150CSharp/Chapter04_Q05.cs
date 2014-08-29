/* Question 4.5
 
Implement a function to check if a binary tree is a binary search tree. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q05
    {
        private static int last = int.MinValue;
        public static bool CheckBST(TreeNode<int> root)
        {
            if (root == null)
                return true;

            if (!CheckBST(root.Left))
                return false;

            if (root.Data < last)
                return false;

            last = root.Data;
            if (!CheckBST(root.Right))
                return false;

            return true;
        }
    }
}

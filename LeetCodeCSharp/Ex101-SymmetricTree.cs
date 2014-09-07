/*
Given a binary tree, check whether it is a mirror of itself 
(ie, symmetric around its center).

For example, this binary tree is symmetric: 
    1
   / \
  2   2
 / \ / \
3  4 4  3

But the following is not:

    1
   / \
  2   2
   \   \
   3    3

Note:
Bonus points if you could solve it both recursively and iteratively. 

class Solution {
public:
    bool isSymmetric(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex101
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) 
                return true;
            return 
                Check(root.Left, root.Right);
        }

        private static bool Check(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode == null && rightNode == null) 
                return true;
            if (leftNode == null || rightNode == null) 
                return false;
            return leftNode.Val == rightNode.Val &&
                Check(leftNode.Left, rightNode.Right) &&
                Check(leftNode.Right, rightNode.Left);
        }
    }
}
/*
Given a binary tree, determine if it is height-balanced. 

For this problem, a height-balanced binary tree is defined
as a binary tree in which the depth of the two subtrees of
every node never differ by more than 1. 

class Solution {
public:
    bool isBalanced(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex110
    {
        public static bool IsBalanced(TreeNode root)
        {
            if (root == null) 
                return true;
            int left = GetHeight(root.Left);
            int right = GetHeight(root.Right);
            if (Math.Abs(left - right) > 1) 
                return false;
            return IsBalanced(root.Left) && IsBalanced(root.Right);
        }

        private static int GetHeight(TreeNode p)
        {
            if (p == null) 
                return 0;
            return Math.Max(GetHeight(p.Left), GetHeight(p.Right)) + 1;
        }
    }
}
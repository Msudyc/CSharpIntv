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
            return GetHeight(root) > 0;
        }

        public static int GetHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = GetHeight(root.Left);
            int right = GetHeight(root.Right);
            if (left < 0 || right < 0 || Math.Abs(left - right) > 1)
                return -1;

            return Math.Max(left, right) + 1;
        }
    }
}
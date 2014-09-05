/*
Given a binary tree, determine if it is a valid binary 
search tree (BST). 

Assume a BST is defined as follows: 
.The left subtree of a node contains only nodes with keys 
 less than the node's key.
.The right subtree of a node contains only nodes with keys 
 greater than the node's key.
.Both the left and right subtrees must also be binary search
 trees.
 
class Solution {
public:
    bool isValidBST(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex098
    {
        public static bool IsValidBST(TreeNode root)
        {
            return DFS(root, null, null);
        }

        private static bool DFS(TreeNode root, TreeNode pre, TreeNode next)
        {
            if (root == null) 
                return true;

            if (pre != null && root.Val <= pre.Val)
                return false;

            if (next != null && root.Val >= next.Val)
                return false;

            return DFS(root.Left, pre, root) && DFS(root.Right, root, next);
        }
    }
}
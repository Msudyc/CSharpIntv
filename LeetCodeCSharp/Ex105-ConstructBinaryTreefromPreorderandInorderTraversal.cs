/*
Given preorder and inorder traversal of a tree, construct
the binary tree.

Note:
 You may assume that duplicates do not exist in the tree. 

class Solution {
public:
    TreeNode *buildTree(List<int> &preorder, List<int> &inorder) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex105
    {
        public static TreeNode BuildTree(List<int> preorder, List<int> inorder)
        {
            int pre_len = preorder.Count;
            int in_len = inorder.Count;
            return Helper(preorder, 0, pre_len - 1, inorder, 0, in_len - 1);
        }

        private static TreeNode Helper(
            List<int> preorder, int ps, int pe, List<int> inorder, int k, int ie)
        {
            if (ps > pe) 
                return null;
            TreeNode root = new TreeNode(preorder[ps]);
            int Val = preorder[ps];
            int i;
            for (i = k; i <= ie; i++)
                if (inorder[i] == Val)
                    break;
            int len = i - k;
            root.Left = Helper(preorder, ps + 1, ps + len, inorder, k, i - 1);
            root.Right = Helper(preorder, ps + len + 1, pe, inorder, i + 1, ie);
            return root;
        }
    }
}
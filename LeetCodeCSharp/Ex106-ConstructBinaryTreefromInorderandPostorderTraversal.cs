/*
Given inorder and postorder traversal of a tree, construct
the binary tree.

Note:
 You may assume that duplicates do not exist in the tree. 

class Solution {
public:
    TreeNode *buildTree(List<int> &inorder, List<int> &postorder) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex106
    {
        private static Dictionary<int, int> mapInorder = new Dictionary<int, int>();

        public static TreeNode BuildTree(List<int> inorder, List<int> postorder)
        {
            if (inorder.Count < 0 && inorder.Count != postorder.Count)
                return null;
            for (int i = 0; i < inorder.Count; i++)
                mapInorder.Add(inorder[i], i);
            return Build(inorder, postorder, 0, inorder.Count - 1, 0, postorder.Count - 1);
        }

        private static TreeNode Build(
            List<int> inorder, List<int> postorder, int sIn, int eIn, int sP, int eP)
        {
            if (sIn > eIn)
                return null;

            if (sIn == eIn)
                return new TreeNode(postorder[eP]);

            int val = postorder[eP];
            TreeNode root = new TreeNode(val);
            int rootIndex = mapInorder[val];
            int leftLen = rootIndex - sIn;
            root.Left = Build(inorder, postorder, sIn, rootIndex - 1, sP, sP + leftLen - 1);
            root.Right = Build(inorder, postorder, rootIndex + 1, eIn, sP + leftLen, eP - 1);
            return root;
        }
    }
}
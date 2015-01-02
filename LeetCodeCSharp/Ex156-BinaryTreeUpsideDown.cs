/*
Given a binary tree where all the right nodes are either leaf nodes 
with a sibling (a left node that shares the same parent node) or empty,
flip it upside down and turn it into a tree where the original right 
nodes turned into left leaf nodes. Return the new root. 
For example:
Given a binary tree {1,2,3,4,5},
    1
   / \
  2   3
 / \
4   5

return the root of the binary tree [4,5,2,#,#,3,1].

   4
  / \
 5   2
    / \
   3   1

class Solution {
public:
    TreeNode *upsideDownBinaryTree(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex156
    {
        public static TreeNode UpsideDownBinaryTree(TreeNode root)
        {
            TreeNode p = root, parent = null, parentRight = null;
            while (p != null)
            {
                TreeNode left = p.Left;
                p.Left = parentRight;
                parentRight = p.Right;
                p.Right = parent;
                parent = p;
                p = left;
            }
            
            return parent;
        }
    }
}
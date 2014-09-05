/*
Two elements of a binary search tree (BST) are swapped 
by mistake.

Recover the tree without changing its structure. 
Note:
 A solution using O(n) space is pretty straight forward. 
 Could you devise a constant space solution?

class Solution {
public:
    void recoverTree(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex099
    {
        public static void RecoverTree(TreeNode root)
        {
            TreeNode[] nodes = new TreeNode[2] {null, null};
            FindNodes(root, null, nodes);
            int temp = nodes[0].Val;
            nodes[0].Val = nodes[1].Val;
            nodes[1].Val = temp;
        }

        private static TreeNode FindNodes(TreeNode root, TreeNode prev, TreeNode[] nodes) 
        {
            if (root == null) 
                return prev;

            TreeNode previous = FindNodes(root.Left, prev, nodes);

            if (previous != null && previous.Val > root.Val) 
            {
                if (nodes[0] == null && nodes[1] == null) 
                { 
                    nodes[0] = previous; 
                    nodes[1] = root; 
                } 
                else nodes[1] = root;
            }
        
            return FindNodes(root.Right, root, nodes);
        }
    }
}
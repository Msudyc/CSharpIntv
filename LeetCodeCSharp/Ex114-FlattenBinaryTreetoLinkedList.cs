/*
Given a binary tree, flatten it to a linked list in-place. 

For example, Given 

         1
        / \
       2   5
      / \   \
     3   4   6
     
The flattened tree should look like:
   1
    \
     2
      \
       3
        \
         4
          \
           5
            \
             6

Hints: 
If you notice carefully in the flattened tree, each node's 
right child points to the next node of a pre-order traversal.

class Solution {
public:
    void flatten(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex114
    {
        public static void Flatten(TreeNode root)
        {
            if (root == null) 
                return;

            TreeNode left = root.Left;
            TreeNode right = root.Right;
            if (left != null)
            {
                root.Right = left;
                root.Left = null;
                TreeNode rightmost = left;
                while (rightmost.Right != null)
                    rightmost = rightmost.Right;

                rightmost.Right = right; // point the right most to the original right child
            }

            Flatten(root.Right);
        }

        public static void FlattenI(TreeNode root)
        {
            Stack<TreeNode> stk = new Stack<TreeNode>();
            while (root != null)
            {
                if (root.Left != null)
                {
                    if (root.Right != null)
                        stk.Push(root.Right);
                    root.Right = root.Left;
                    root.Left = null;
                }
                else
                {
                    if (root.Right == null && stk.Count > 0)
                        root.Right = stk.Pop();
                }

                root = root.Right;
            }
        }
    }
}
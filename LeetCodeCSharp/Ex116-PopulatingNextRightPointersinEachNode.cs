/*
Given a binary tree 
    struct TreeLinkNode {
      TreeLinkNode *left;
      TreeLinkNode *right;
      TreeLinkNode *next;
    }

Populate each next pointer to point to its next right node. 
If there is no next right node, the next pointer should be
set to null.

Initially, all next pointers are set to null.

Note: 
.You may only use constant extra space.
.You may assume that it is a perfect binary tree 
(ie, all leaves are at the same level, and every parent has
two children).

For example,
 Given the following perfect binary tree,

         1
       /  \
      2    3
     / \  / \
    4  5  6  7

After calling your function, the tree should look like:

         1 . null
       /  \
      2 . 3 . null
     / \  / \
    4.5.6.7 . null

class Solution {
public:
    void connect(TreeLinkNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex116
    {
        public static void Connect(TreeLinkNode root)
        {
            TreeLinkNode leftWall = root;
            while (leftWall != null)
            {
                TreeLinkNode across = leftWall;
                while (across != null)
                {
                    if (across.Left != null) 
                        across.Left.Next = across.Right;

                    if (across.Right != null && across.Next != null) 
                        across.Right.Next = across.Next.Left;

                    across = across.Next;
                }

                leftWall = leftWall.Left;
            }
        }
    }
}
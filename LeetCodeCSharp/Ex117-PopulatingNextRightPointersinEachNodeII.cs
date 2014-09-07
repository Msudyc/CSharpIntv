/*
Follow up for problem "Populating Next Right Pointers in 
Each Node".

What if the given tree could be any binary tree? 
Would your previous solution still work?

Note: 
.You may only use constant extra space.

For example, Given the following binary tree,

         1
       /  \
      2    3
     / \    \
    4   5    7

After calling your function, the tree should look like:

         1 . null
       /  \
      2 . 3 . null
     / \    \
    4. 5 . 7 . null

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

    public class Ex117
    {
        public static void Connect(TreeLinkNode root)
        {
            while (root != null)
            {
                TreeLinkNode next = null; // the first node of next level
                TreeLinkNode prev = null; // previous node on the same level
                for (; root != null; root = root.Next)
                {
                    if (null == next) 
                        next = root.Left != null ? root.Left : root.Right;

                    if (root.Left != null)
                    {
                        if (prev != null) 
                            prev.Next = root.Left;
                        prev = root.Left;
                    }
                    if (root.Right != null)
                    {
                        if (prev != null) 
                            prev.Next = root.Right;
                        prev = root.Right;
                    }
                }

                root = next; // turn to next level
            }
        }
    }
}
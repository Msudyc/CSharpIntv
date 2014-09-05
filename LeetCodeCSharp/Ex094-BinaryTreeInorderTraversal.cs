/*
Given a binary tree, return the inorder traversal of 
its nodes' values.

For example:
 Given binary tree {1,#,2,3},

   1
    \
     2
    /
   3

return [1,3,2]. 

Note: Recursive solution is trivial, could you do it 
iteratively?

class Solution {
public:
    List<int> inorderTraversal(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex094
    {
        public static List<int> InorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stk = new Stack<TreeNode>();
            TreeNode current = root;
            while (stk.Count != 0 || current != null)
            {
                if (current != null)
                {
                    stk.Push(current);
                    current = current.Left;
                }
                else
                {
                    current = stk.Peek();
                    stk.Pop();
                    res.Add(current.Val);
                    current = current.Right;
                }
            }

            return res;
        }
    }
}
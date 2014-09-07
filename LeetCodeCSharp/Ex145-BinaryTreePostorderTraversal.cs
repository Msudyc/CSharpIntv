/*
Given a binary tree, return the postorder traversal of its
nodes' values.

For example: Given binary tree {1,#,2,3},

   1
    \
     2
    /
   3

return [3,2,1]. 

Note: Recursive solution is trivial, could you do it iteratively?

class Solution {
public:
    List<int> postorderTraversal(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex145
    {
        public static List<int> PostorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            if (root == null) 
                return res;

            Stack<TreeNode> stk = new Stack<TreeNode>();
            stk.Push(root);

            TreeNode prev = null;
            while (stk.Count != 0)
            {
                TreeNode curr = stk.Peek();
                if (null == prev || prev.Left == curr || prev.Right == curr)
                {
                    if (curr.Left != null) 
                        stk.Push(curr.Left);
                    else if (curr.Right != null) 
                        stk.Push(curr.Right);
                }
                else if (curr.Left == prev)
                {
                    if (curr.Right != null) 
                        stk.Push(curr.Right);
                }
                else
                {
                    res.Add(curr.Val);
                    stk.Pop();
                }

                prev = curr;
            }

            return res;
        }
    }
}
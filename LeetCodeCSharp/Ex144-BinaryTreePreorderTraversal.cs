/*
Given a binary tree, return the preorder traversal of its
nodes' values.

For example: Given binary tree {1,#,2,3},

   1
    \
     2
    /
   3

return [1,2,3]. 

Note: 
Recursive solution is trivial, could you do it iteratively?

class Solution {
public:
    List<int> preorderTraversal(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex144
    {
        public static List<int> PreorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            if (root == null) 
                return res;

            Stack<TreeNode> stk = new Stack<TreeNode>();
            stk.Push(root);

            TreeNode cur = null;
            while (stk.Count != 0)
            {
                cur = stk.Pop();
                res.Add(cur.Val);

                if (cur.Right != null)
                    stk.Push(cur.Right);

                if (cur.Left != null) 
                    stk.Push(cur.Left);
            }

            return res;
        }
    }
}
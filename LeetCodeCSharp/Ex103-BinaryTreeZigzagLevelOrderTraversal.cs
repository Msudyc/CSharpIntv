/*
Given a binary tree, return the zigzag level order traversal
of its nodes' values. (ie, from left to right, then right to 
left for the next level and alternate between).

For example:
 Given binary tree {3,9,20,#,#,15,7},

    3
   / \
  9  20
    /  \
   15   7



return its zigzag level order traversal as:

[
  [3],
  [20,9],
  [15,7]
]

class Solution {
public:
    List<List<int> > zigzagLevelOrder(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex103
    {
        public static List<List<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            if (root == null) 
                return result;
            
            Stack<TreeNode> curLevel = new Stack<TreeNode>();
            Stack<TreeNode> nextLevel = new Stack<TreeNode>();
            bool leftToRight = true;
            curLevel.Push(root);
            List<int> levelVals = new List<int>();
            while (curLevel.Count != 0)
            {
                TreeNode cur = curLevel.Pop();                
                if (cur != null)
                {
                    levelVals.Add(cur.Val);
                    if (leftToRight)
                    {
                        nextLevel.Push(cur.Left);
                        nextLevel.Push(cur.Right);
                    }
                    else
                    {
                        nextLevel.Push(cur.Right);
                        nextLevel.Push(cur.Left);
                    }
                }
                if (curLevel.Count == 0)
                {
                    if (levelVals.Count != 0)
                    {
                        result.Add(levelVals);
                        levelVals = new List<int>();
                    }

                    leftToRight = !leftToRight;
                    // swap curLevel nextLevel
                    Stack<TreeNode> temp = curLevel;
                    curLevel = nextLevel;
                    nextLevel = temp;
                }
            }

            return result;
        }
    }
}
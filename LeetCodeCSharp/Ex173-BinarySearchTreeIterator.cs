/*
Implement an iterator over a binary search tree (BST). 
Your iterator will be initialized with the root node of a BST.

Calling next() will return the next smallest number in the BST.

Note: next() and hasNext() should run in average O(1) time and 
uses O(h) memory, where h is the height of the tree.

class BSTIterator {
public:
    BSTIterator(TreeNode *root) {
        
    }

    // @return whether we have a next smallest number
    bool hasNext() {
        
    }

    // @return the next smallest number
    int next() {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex173
    {
        public class BSTIterator 
        {
            private Stack<TreeNode> stack = new Stack<TreeNode>();
            private TreeNode current;

            public BSTIterator(TreeNode root) 
            {
                this.current = root;
            }
            
            /** @return whether we have a next smallest number */
            public bool HasNext() 
            {
                return (this.stack.Count > 0 || this.current != null);
            }
            
            /** @return the next smallest number */
            public int Next() 
            {
                while (current != null) 
                {
                    this.stack.Push(current);
                    current = current.Left;
                }
                
                this.current = stack.Pop();
                int value = current.Val;
                current = current.Right;
                return value;
            }
        }
    }
}
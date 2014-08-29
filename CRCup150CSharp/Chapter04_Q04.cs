/* Question 4.4
 
Given a binary tree, design an algorithm which creates a linked list 
of all the nodes at each depth (e.g., if you have a tree with depth D, 
you'll have D linked lists). 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q04
    {
        public static List<LinkedList<TreeNode<T>>> CreateLevelLinkedList<T>(TreeNode<T> root)
        {
            List<LinkedList<TreeNode<T>>> result = new List<LinkedList<TreeNode<T>>>();
            LinkedList<TreeNode<T>> current = new LinkedList<TreeNode<T>>();

            if (root != null)
                current.AddLast(root);

            while (current.Count > 0)
            {
                result.Add(current);
                LinkedList<TreeNode<T>> parents = current;
                current = new LinkedList<TreeNode<T>>();
                foreach (TreeNode<T> parent in parents)
                {
                    if (parent.Left != null)
                        current.AddLast(parent.Left);
                    if (parent.Right != null)
                        current.AddLast(parent.Right);
                }
            }

            return result;
        }
    }
}

/* Question 4.7
 
Design an algorithm and write code to find the first common ancestor of two 
nodes in a binary tree. Avoid storing additional nodes in a data structure. 
Note: this is not necessarily a binary search tree. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q07
    {
        public static TreeNode<T> CommonAncestor<T>(TreeNode<T> root, TreeNode<T> p, TreeNode<T> q)
        {
            Tuple<bool, TreeNode<T>> result = Helper(root, p, q);
            if (result.Item1 == true)
                return result.Item2;

            return null;
        }

        private static Tuple<bool, TreeNode<T>> Helper<T>(TreeNode<T> root, TreeNode<T> p, TreeNode<T> q)
        {
            if (root == null)
                return new Tuple<bool, TreeNode<T>>(false, null);

            if (root == p && root == q)
                return new Tuple<bool, TreeNode<T>>(true, root);

            Tuple<bool, TreeNode<T>> rx = Helper(root.Left, p, q);
            if (rx.Item1 == true)
                return rx;

            Tuple<bool, TreeNode<T>> ry = Helper(root.Right, p, q);
            if (ry.Item1 == true)
                return ry;

            if (rx.Item2 != null && ry.Item2 != null)
                return new Tuple<bool, TreeNode<T>>(true, root);
            else if (root == p || root == q)
            {
                bool isAncestor = rx.Item2 != null || ry.Item2 != null ? true : false;
                return new Tuple<bool, TreeNode<T>>(isAncestor, root);
            }
            else
                return new Tuple<bool, TreeNode<T>>(
                    false, rx.Item2 != null ? rx.Item2 : ry.Item2);
        }
    }
}

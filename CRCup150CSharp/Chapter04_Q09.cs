/* Question 4.9
 
You are given a binary tree in which each node contains a value. 
Design an algorithm to print all paths which sum to a given value. 
Note that a path can start or end anywhere in the tree. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q09
    {
        public static List<List<TreeNode<int>>> FindSum(TreeNode<int> root, int sum)
        {
            List<List<TreeNode<int>>> result = new List<List<TreeNode<int>>>();
            List<TreeNode<int>> temp = new List<TreeNode<int>>();
            FindSum(root, result, temp, sum);
            return result;
        }

        private static void FindSum(
            TreeNode<int> node, 
            List<List<TreeNode<int>>> result, 
            List<TreeNode<int>> temp, 
            int sum)
        {
            if (node == null)
                return;

            temp.Add(node);
            int t = 0;
            for (int i = temp.Count - 1; i >= 0; i--)
            {
                t += temp[i].Data;
                if (t == sum)
                    AddIntoResult(result, temp, i, temp.Count - 1);
            }

            FindSum(node.Left, result, temp, sum);
            FindSum(node.Right, result, temp, sum);
            temp.Remove(node);
        }

        private static void AddIntoResult(
            List<List<TreeNode<int>>> result,
            List<TreeNode<int>> temp,
            int start,
            int end)
        {
            List<TreeNode<int>> r = new List<TreeNode<int>>();
            for (int i = start; i <= end; i++)
                r.Add(temp[i]);
            result.Add(r);
        }
    }
}

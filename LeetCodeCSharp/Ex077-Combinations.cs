/*
Given two integers n and k, return all possible 
combinations of k numbers out of 1 ... n. 

For example,
 If n = 4 and k = 2, a solution is: 
[
  [2,4],
  [3,4],
  [2,3],
  [1,2],
  [1,3],
  [1,4],
]

class Solution {
public:
    List<List<int> > combine(int n, int k) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex077
    {
        public static List<List<int>> Combine(int n, int k)
        {        
            List<List<int>> ret = new List<List<int>>();
            List<List<int>> temp = new List<List<int>>();
            temp.Add(new List<int>());

            for (int i = 1; i <= n; i++)
                for (int j = temp.Count - 1; j >= 0; j--) 
                    if (temp[j].Count == k - 1) 
                    {
                        ret.Add(new List<int>(temp[j])); // copy
                        ret[ret.Count - 1].Add(i);
                    } 
                    else 
                    {
                        temp.Add(new List<int>(temp[j]));
                        temp[temp.Count-1].Add(i);
                    }

            return ret;
        }

        public static List<List<int>> CombineDFS(int n, int k)
        {
            List<List<int>> ret = new List<List<int>>();
            List<int> combination = new List<int>();
            DFS(ret, combination, 1, n, k);
            return ret;
        }

        private static void DFS(
            List<List<int>> result, List<int> combination, int next, int n, int k)
        {
            if (combination.Count == k)
                result.Add(new List<int>(combination));

            for (int i = next; i <= n; i++)
            {
                combination.Add(i);
                DFS(result, combination, i + 1, n, k);
                combination.Remove(i);
            }
        }
    }
}
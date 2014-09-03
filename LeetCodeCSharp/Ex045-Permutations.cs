/*
Given a collection of numbers, return all possible permutations. 

For example,
[1,2,3] have the following permutations:
[1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], and [3,2,1]. 

class Solution {
public:
    List<List<int> > permute(List<int> &num) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex045
    {
        public static List<List<int>> Permute(List<int> num)
        {
            List<List<int>> res = new List<List<int>>();
            Perm(num, 0, res);
            return res;
        }

        private static void Perm(List<int> num, int k, List<List<int>> res)
        {
            if (k == num.Count - 1) 
                res.Add(num);
            else
                for (int i = k; i < num.Count; i++)
                {
                    Swap(num, k, i);
                    Perm(num, k + 1, res);
                    Swap(num, k, i);
                }
        }

        private static void Swap(List<int> num, int i, int j)
        {
            int tmp = num[i];
            num[i] = num[j];
            num[j] = tmp;
        }
    }
}
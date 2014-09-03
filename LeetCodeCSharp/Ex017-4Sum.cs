/*
Given an array S of n integers, are there elements a, b, c, 
and d in S such that a + b + c + d = target? Find all unique 
quadruplets in the array which gives the sum of target.

Note:

.Elements in a quadruplet (a,b,c,d) must be in non-descending 
 order. (ie, a ≤ b ≤ c ≤ d)
.The solution set must not contain duplicate quadruplets.

    For example, given array S = {1 0 -1 0 -2 2}, and target = 0.

    A solution set is:
    (-1,  0, 0, 1)
    (-2, -1, 1, 2)
    (-2,  0, 0, 2)

class Solution {
public:
    List<List<int> > fourSum(List<int> &num, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex017
    {
        public static List<List<int>> FourSum(List<int> num, int target)
        {
            List<List<int>> res = new List<List<int>>();            
            int size = num.Count;
            if (size < 4)
                return res;
            num.Sort();
            for (int i = 0; i < size-3; i++)
            {
                if (i != 0 && num[i] == num[i - 1]) 
                    continue;
                for (int j = i + 1; j < size-2; ++j)
                {
                    if (j != i + 1 && num[j] == num[j - 1]) 
                        continue;
                    int p = j + 1, q = size - 1;
                    while (p < q)
                    {
                        if (p != j + 1 && num[p] == num[p - 1]) 
                        { 
                            p++; 
                            continue; 
                        }
                        if (q != size - 1 && num[q] == num[q + 1]) 
                        { 
                            q--; 
                            continue; 
                        }
                        int sum = num[i] + num[j] + num[p] + num[q];
                        if (sum == target)
                        {
                            List<int> t = new List<int>();
                            t.Add(num[i]);
                            t.Add(num[j]);
                            t.Add(num[p]);
                            t.Add(num[q]);
                            res.Add(t);
                            p++;
                            q--;
                        }
                        else if (sum > target) 
                            q--;
                        else 
                            p++;
                    }
                }
            }

            return res;
        }
    }
}
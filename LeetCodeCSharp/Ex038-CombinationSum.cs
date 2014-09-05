/*
Given a set of candidate numbers (C) and a target number (T), 
find all unique combinations in C where the candidate numbers 
sums to T. 

The same repeated number may be chosen from C unlimited number
of times. 

Note:

.All numbers (including target) will be positive integers.
.Elements in a combination (a1, a2, … , ak) must be in 
 non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
.The solution set must not contain duplicate combinations.

For example, given candidate set 2,3,6,7 and target 7, A 
solution set is: 

[7] 
[2, 2, 3] 

class Solution {
public:
    List<List<int> > combinationSum(List<int> &candidates, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex038
    {
        public static List<List<int> > CombinationSum(List<int> candidates, int target)
        {
            List<List<int>> res = new List<List<int>>();
            if (candidates.Count == 0)
                return res;
            candidates.Sort();
            List<int> r = new List<int>();
            Dfs(candidates, target, res, r, 0);
            return res;
        }

        private static void Dfs(List<int> candidates, int target, List<List<int> > res, List<int> r, int i)
        {
            if (target < 0) 
                return;
            else if (target == 0) 
                res.Add(r);
            else
                while (i < candidates.Count && target - candidates[i] >= 0)
                {
                    r.Add(candidates[i]);
                    Dfs(candidates, target-candidates[i], res, r, i);
                    r.Remove(candidates[i]);
                    i++;                    
                }
        }
    }
}
/*
Given a collection of candidate numbers (C) and a target 
number (T), find all unique combinations in C where the 
candidate numbers sums to T. 

Each number in C may only be used once in the combination. 

Note:

.All numbers (including target) will be positive integers.
.Elements in a combination (a1, a2, … , ak) must be in 
 non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
.The solution set must not contain duplicate combinations.


For example, given candidate set 10,1,2,7,6,1,5 and target 
8, A solution set is: 

[1, 7] 
[1, 2, 5] 
[2, 6] 
[1, 1, 6] 

class Solution {
public:
    List<List<int> > combinationSum2(List<int> &num, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex039
    {
        public static List<List<int>> CombinationSum2(List<int> num, int target)
        {
            List<List<int>> res = new List<List<int>>();
            if (num.Count == 0) 
                return res;
            num.Sort();
            List<int> r = new List<int>();
            Dfs(num, target, res, r, 0);
            return res;
        }

        private static void Dfs(List<int> num, int target, List<List<int>> res, List<int> r, int st)
        {
            if (target < 0) 
                return;
            else if (target == 0) 
                res.Add(r);
            else
            {
                int pre = -1;
                for (int i = st; i < num.Count; i++)
                    // avoid dup
                    if (num[i] != pre)
                    {
                        r.Add(num[i]);
                        Dfs(num, target - num[i], res, r, i + 1);
                        pre = num[i];
                        r.Remove(num[i]);
                    }
            }
        }
    }
}
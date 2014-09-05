/*
Given a collection of integers that might contain duplicates, 
S, return all possible subsets. 

Note:

.Elements in a subset must be in non-descending order.
.The solution set must not contain duplicate subsets.

For example,
 If S = [1,2,2], a solution is: 
[
  [2],
  [1],
  [1,2,2],
  [2,2],
  [1,2],
  []
]

class Solution {
public:
    List<List<int> > subsetsWithDup(List<int> &S) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex091
    {
        public static List<List<int>> SubsetsWithDup(List<int> S)
        {
            S.Sort();
            List<List<int>> res = new List<List<int>>();
            List<int> r = new List<int>();
            res.Add(r);
            r.Add(S[0]);
            res.Add(r);
            int pre = S[0];
            int count = 1;
            for (int i = 1; i < S.Count; i++)
            {
                int st = 0;
                int sz = res.Count;
                if (S[i] == pre) 
                    st = sz - count;
                count = 0;
                for (int j = st; j < sz; j++)
                {
                    r = res[j];
                    r.Add(S[i]);
                    res.Add(r);
                    count++;
                }

                pre = S[i];
            }

            return res;
        }

        private static List<List<int>> SubsetsWithDupR(List<int> S)
        {
            List<int> path = new List<int>();
            List<List<int>> result = new List<List<int>>();
            S.Sort();
            Sub(S, 0, path, result);
            return result;
        }

        private static void Sub(List<int> s, int begin, List<int> path, List<List<int>> result)
        {
            result.Add(path);
            for (int i = begin; i < s.Count; i++)
            {
                if (i != begin && s[i] == s[i - 1]) 
                    continue;
                path.Add(s[i]);
                Sub(s, i + 1, path, result);
                path.Remove(s[i]);
            }
        }
    }
}
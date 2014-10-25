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
            List<List<int>> result = new List<List<int>>();
            result.Add(new List<int>());

            int lastAddNum = 1;
            for (int i = 0; i < S.Count; i++)
            {
                int stopIndex = (i > 0 && S[i] == S[i - 1]) ? result.Count - lastAddNum : 0;
                lastAddNum = 0;
                for (int j = result.Count - 1; j >= stopIndex; j--)
                {
                    List<int> t = new List<int>(result[j]);
                    t.Add(S[i]);
                    result.Add(t);
                    lastAddNum++;
                }
            }

            return result;
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
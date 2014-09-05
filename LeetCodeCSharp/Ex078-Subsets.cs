/*
Given a set of distinct integers, S, return all possible
subsets. 

Note:
.Elements in a subset must be in non-descending order.
.The solution set must not contain duplicate subsets.

For example,
 If S = [1,2,3], a solution is: 
[
  [3],
  [1],
  [2],
  [1,2,3],
  [1,3],
  [2,3],
  [1,2],
  []
]

class Solution {
public:
    List<List<int> > subsets(List<int> &S) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex078
    {
        public static List<List<int>> Subsets(List<int> S)
        {
            S.Sort();
            List<List<int> > v = new List<List<int>>();
            v.Add(new List<int>());
            for(int i = 0; i < S.Count; i++) 
            {
                int j = v.Count;
                while(j-- > 0) 
                {
                    v.Add(new List<int>(v[j]));
                    v[j].Add(S[i]);
                }
            }
        
            return v;
        }
    }
}
/*
Given a triangle, find the minimum path sum from top to
bottom. Each step you may move to adjacent numbers on the
row below.

For example, given the following triangle

[
     [2],
    [3,4],
   [6,5,7],
  [4,1,8,3]
]
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex120
    {
        public static int MinimumTotal(List<List<int>> triangle)
        {
            int n = triangle.Count;
            int[] p = new int[n+1];

            while(n-- > 0)
                for(int i = 0; i <= n; i++)
                    p[i] = triangle[n][i] + 
                        ((p[i] < p[i+1]) ? p[i] : p[i+1]);

            return p[0];
        }

        public static int MinimumTotal2(List<List<int>> triangle)
        {
            if (triangle.Count == 0)
                return 0;

            List<int> last = new List<int>(triangle[triangle.Count - 1]);
            for (int i = triangle.Count - 2; i >= 0; i--)
                for (int j = 0; j < triangle[i].Count; j++)
                    last[j] = Math.Min(last[j], last[j + 1]) + triangle[i][j];

            return last[0];
        }
    }
}
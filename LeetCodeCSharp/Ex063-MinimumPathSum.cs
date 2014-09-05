/*
Given a m x n grid filled with non-negative numbers, find 
a path from top left to bottom right which minimizes the 
sum of all numbers along its path.

Note: You can only move either down or right at any point
in time.

class Solution {
public:
    int minPathSum(List<List<int> > &grid) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex063
    {
        public static int MinPathSum(int[,] grid)
        {
            if (grid.Length == 0) 
                return 0;

            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            int[,] temp = new int[m, n];

            temp[0, 0] = grid[0, 0];
            for (int i = 1; i < n; i++) 
                temp[0, i] = temp[0, i-1] + grid[0, i];
            for (int i = 1; i < m; i++) 
                temp[i, 0] = temp[i-1, 0] + grid[i, 0];  

            for(int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    temp[i, j] = Math.Min(temp[i, j-1], temp[i-1, j]) + grid[i, j];

            return temp[m-1, n-1];
        }

        public static int MinPathSumDP(int[,] grid)
        {
            if (grid.Length == 0) 
                return 0;

            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            int[] dp = new int[n + 1];
            dp[0] = 0;
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    dp[j + 1] = Math.Min(dp[j + 1], dp[j]) + grid[i, j];

            return dp[n];
        }
    }
}
/*
A robot is located at the top-left corner of a m x n grid 
(marked 'Start' in the diagram below).

The robot can only move either down or right at any point 
in time. The robot is trying to reach the bottom-right corner 
of the grid (marked 'Finish' in the diagram below).

How many possible unique paths are there?

Above is a 3 x 7 grid. How many possible unique paths are 
there? 

Note: m and n will be at most 100.

class Solution {
public:
    int uniquePaths(int m, int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex061
    {
        public static int UniquePaths(int m, int n)
        {
            int[,] temp = new int[m, n];
            for (int i = 0; i< m; i++) 
                temp[i, 0] = 1;
            for (int i = 0; i< n; i++) 
                temp[0, i] = 1;

            for (int i = 1; i < m; i++)
                for(int j = 1; j< n; j++)
                    temp[i, j] = temp[i, j-1] + temp[i-1, j];

            return temp[m-1, n-1];
        }
    }
}
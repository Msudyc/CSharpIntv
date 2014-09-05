/*
Follow up for "Unique Paths":

Now consider if some obstacles are added to the grids. How 
many unique paths would there be?

An obstacle and empty space is marked as 1 and 0 respectively 
in the grid.

For example,

There is one obstacle in the middle of a 3x3 grid as 
illustrated below.

[
  [0,0,0],
  [0,1,0],
  [0,0,0]
]

The total number of unique paths is 2.

Note: m and n will be at most 100.

class Solution {
public:
    int uniquePathsWithObstacles(List<List<int> > &obstacleGrid) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex062
    {
        public static int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            if (obstacleGrid[0, 0] == 1) 
                return 0;

            int m = obstacleGrid.GetLength(0);
            int n = obstacleGrid.GetLength(1);
            int[,] temp = new int[m, n];

            temp[0, 0] = 1;
            for (int i = 1; i < m; i++)
                if (obstacleGrid[i, 0] != 1)
                    temp[i, 0] = temp[i-1, 0];

            for (int i = 1; i < n; i++)
                if (obstacleGrid[0, i]!=1)
                    temp[0, i] = temp[0, i-1];

            for (int i = 1; i < m; i++)
                for(int j = 1; j < n; j++)
                    if (obstacleGrid[i, j] != 1)
                        temp[i, j] = temp[i, j-1] + temp[i-1, j];

            return temp[m-1, n-1];
        }
    }
}
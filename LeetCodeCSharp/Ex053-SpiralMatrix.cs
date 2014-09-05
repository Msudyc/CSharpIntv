/*
Given a matrix of m x n elements (m rows, n columns), return 
all elements of the matrix in spiral order. 

For example,
 Given the following matrix: 
[
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
]

You should return [1,2,3,6,9,8,7,4,5]. 

class Solution {
public:
    List<int> spiralOrder(List<List<int> > &matrix) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex053
    {
        public static List<int> SpiralOrder(int[,] matrix)
        {
            List<int> ret = new List<int>();
            if (matrix.Length == 0) 
                return ret;
            int left = -1, right = matrix.GetLength(1) - 1, 
                top = 0, bottom = matrix.GetLength(0) - 1;

            while (left <= right && top <= bottom)
            {
                // left to right
                for (int j = ++left; top <= bottom && j <= right; j++)
                    ret.Add(matrix[top, j]);
                // up to down
                for (int i = ++top; left <= right && i <= bottom; i++)
                    ret.Add(matrix[i, right]);
                // right to left
                for (int j = --right; top <= bottom && j >= left; j--)
                    ret.Add(matrix[bottom, j]);
                // down to up
                for (int i = --bottom; left <= right && i >= top; i--)
                    ret.Add(matrix[i, left]);
            }

            return ret;
        }
    }
}
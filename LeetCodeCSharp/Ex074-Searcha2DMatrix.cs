/*
Write an efficient algorithm that searches for a value in 
an m x n matrix. This matrix has the following properties:

.Integers in each row are sorted from left to right.
.The first integer of each row is greater than the last 
 integer of the previous row.

For example,

Consider the following matrix: 
[
  [1,   3,  5,  7],
  [10, 11, 16, 20],
  [23, 30, 34, 50]
]

Given target = 3, return true.

class Solution {
public:
    bool searchMatrix(List<List<int> > &matrix, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex074
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(0);
            int low = 0, high = rows * cols - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (matrix[mid / cols, mid % cols] == target) 
                    return true;
                else if (matrix[mid / cols, mid % cols] < target) 
                    low = mid + 1;
                else if (matrix[mid / cols, mid % cols] > target) 
                    high = mid - 1;
            }

            return false;
        }
    }
}
/*
You are given an n x n 2D matrix representing an image.

Rotate the image by 90 degrees (clockwise).

Follow up:
 Could you do this in-place?

class Solution {
public:
    void rotate(List<List<int> > &matrix) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex047
    {
        public static void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first, i];
                    matrix[first, i] = matrix[last - offset, first]; //left.top                
                    matrix[last - offset, first] = matrix[last, last - offset]; //bottom.top                
                    matrix[last, last - offset] = matrix[i, last]; //right.bottom                
                    matrix[i, last] = top; //top.Right
                }
            }
        }
    }
}
/*
Given a m x n matrix, if an element is 0, set its entire 
row and column to 0. Do it in place. 

Follow up: 
Did you use extra space?
 A straight forward solution using O(mn) space is probably
 a bad idea. A simple improvement uses O(m + n) space, but 
 still not the best solution. Could you devise a constant 
 space solution? 

class Solution {
public:
    void setZeroes(List<List<int> > &matrix) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex073
    {
        public static void SetZeroes(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            if (0 == rows) 
                return;

            int cols = matrix.GetLength(1);
            if (0 == cols) 
                return;

            //using first row and col as storage
            //1.search zero in first row and col to determin it's own status
            bool zerorow0 = false;
            bool zerocol0 = false;
            for (int ci = 0; ci < cols; ci++)
                if (matrix[0, ci] == 0) 
                { 
                    zerorow0 = true; 
                    break; 
                }

            for (int ri = 0; ri < rows; ri++)
                if (matrix[ri, 0] == 0) 
                { 
                    zerocol0 = true; 
                    break; 
                }

            //2.search zeros in other position to sign the first row and col
            for (int ri = 1; ri < rows; ri++)
                for (int ci = 1; ci < cols; ci++)
                    if (matrix[ri, ci] == 0) 
                    { 
                        matrix[0, ci] = 0; 
                        matrix[ri, 0] = 0; 
                    }

            //3.set zeroes in other positions according to first col and row
            for (int ri = 1; ri < rows; ri++)
                for (int ci = 1; ci < cols; ci++)
                    if (matrix[0, ci] == 0 || matrix[ri, 0] == 0)
                        matrix[ri, ci] = 0;

            //4.set zeroes for first row and col
            if (zerorow0)
                for (int ci = 0; ci < cols; ++ci) 
                    matrix[0, ci] = 0;
            if (zerocol0)
                for (int ri = 0; ri < rows; ++ri) 
                    matrix[ri, 0] = 0;
        }
    }
}
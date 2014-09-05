/*
Given an integer n, generate a square matrix filled with 
elements from 1 to n2 in spiral order.

For example,
 Given n = 3, 
You should return the following matrix: 

[
 [ 1, 2, 3 ],
 [ 8, 9, 4 ],
 [ 7, 6, 5 ]
]

class Solution {
public:
    List<List<int> > generateMatrix(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex058
    {
        public static int[,] GenerateMatrix(int n)
        {
            int[,] res = new int[n, n];
            if (n == 0) 
                return res;
            int i = 1, x = 0, y = 0;
            res[0,0] = i++;
            while (i <= n*n)
            {
                while (y+1 < n && res[x,y+1] == 0)
                {   // keep going right
                    res[x,++y] = i++;
                }
                while (x+1 < n && res[x+1,y] == 0)
                {   // keep going down
                    res[++x,y] = i++;
                }
                while (y-1 >= 0 && res[x,y-1] == 0)
                {  // keep going left
                    res[x,--y] = i++;
                }
                while (x-1 >= 0 && res[x-1, y] == 0)
                {  // keep going up
                    res[--x, y]=i++;
                }
            }

            return res;
        }
    }
}
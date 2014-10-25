/*
Given a 2D binary matrix filled with 0's and 1's, find the 
largest rectangle containing all ones and return its area.

class Solution {
public:
    int maximalRectangle(List<List<char> > &matrix) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex085
    {
        public static int MaximalRectangle(char[,] matrix)
        {
            if (matrix.Length == 0) 
                return 0;

            int ret = 0, n = matrix.GetLength(1), m = matrix.GetLength(0);
            //L - the position of the left nearest 0 in this row 
            //R - the position of the right nearest 0 in this row 

            int[] H = new int[n];
            int[] L = new int[n];
            int[] R = new int[n];
            for (int i = 0; i < m; i++) 
            {
                int left = 0, right = n;
                // calculate L(i, j) from left to right
                for (int j = 0; j < n; j++) 
                {
                    if (matrix[i, j] == '1') 
                    { 
                        H[j]++; 
                        L[j] = Math.Max(L[j], left); 
                    }
                    else 
                    { 
                        left = j+1; 
                        H[j] = 0; 
                        L[j] = 0; 
                        R[j] = n; 
                    }
                }
                // calculate R(i, j) from right to left
                for (int j = n-1; j >= 0; --j) 
                {
                    if (matrix[i, j] == '1') 
                    { 
                        R[j] = Math.Min(R[j], right); 
                        ret = Math.Max(ret, H[j]*(R[j]-L[j]));
                    }
                    else  
                        right = j;
                }
            }

            return ret;
        }

        public static int MaximalRectangle2(char[,] matrix)
        {
            if (matrix.Length == 0)
                return 0;

            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int max = 0;
            int[] height = new int[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == '1')
                        height[j]++;
                    else
                        height[j] = 0;
                }

                max = Math.Max(max, LargestRectangleArea(new List<int>(height)));
            }

            return max;
        }

        private static int LargestRectangleArea(List<int> height)
        {
            Stack<int> stk = new Stack<int>();
            height.Add(0);
            int result = 0;
            for (int i = 0; i < height.Count; )
            {
                if (stk.Count == 0 || (height[i] > height[stk.Peek()]))
                    stk.Push(i++);
                else
                {
                    int t = stk.Pop();
                    int area = height[t] * (stk.Count == 0 ? i : i - stk.Peek() - 1);
                    result = Math.Max(result, area);
                }
            }

            return result;
        }
    }
}
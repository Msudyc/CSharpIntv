/*
Follow up for N-Queens problem.

Now, instead outputting board configurations, return 
the total number of distinct solutions.

class Solution {
public:
    int totalNQueens(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex051
    {
        public static int TotalNQueens(int n)
        {
            int res=0;
            int[] A = new int[n];
            Nqueens(A, 0, ref res);
            return res;
        }

        private static void Nqueens(int[] A, int cur, ref int res)
        {
            if (cur == A.Length) 
            { 
                res++;
            }
            else
                for (int i = 0; i < A.Length; i++)
                {
                    A[cur] = i;
                    if (IsValid(A, cur))
                        Nqueens(A, cur+1, ref res);
                }
        }

        private static bool IsValid(int[] A, int r)
        {
            for (int i = 0; i < r; i++)
                if ((A[i] == A[r]) || (Math.Abs(A[i] - A[r]) == (r-i)))
                    return false; 
            return true;
        }
    }
}
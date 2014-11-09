/*
Find the contiguous subarray within an array (containing at least one number) 
which has the largest product. 

For example, given the array [2,3,-2,4],
 the contiguous subarray [2,3] has the largest product = 6. 

public class Solution {
    public int maxProduct(int[] A) {
        
    }
}
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex152
    {
        public static int MaxProduct(int[] A)
        {
            int max = A[0], min = A[0], maxAns = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                int mx = max, mn = min;
                max = Math.Max(Math.Max(A[i], mx * A[i]), mn * A[i]);
                min = Math.Min(Math.Min(A[i], mx * A[i]), mn * A[i]);
                maxAns = Math.Max(max, maxAns);
            }

            return maxAns;
        }
    }
}
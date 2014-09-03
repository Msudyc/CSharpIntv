/*
Given n non-negative integers representing an elevation 
map where the width of each bar is 1, compute how much 
water it is able to trap after raining. 

For example, 
 Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6. 

class Solution {
public:
    int trap(int A[], int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex041
    {
        public static int Trap(int[] A)
        {
            int[] l = new int[A.Length];
            int[] r = new int[A.Length];

            int lmax = 0, rmax = 0, v = 0;
            for (int i = 0; i < A.Length; i++)
            { 
                l[i] = lmax; 
                lmax = Math.Max(lmax, A[i]);            
            }
            for (int i = A.Length - 1; i >= 0; i--)
            { 
                r[i] = rmax; 
                rmax = Math.Max(rmax, A[i]); 
            }

            for (int i = 0; i < A.Length; i++)
            {
                int threshold = Math.Min(l[i], r[i]);
                if (A[i] < threshold) 
                    v += threshold - A[i];
            }
        
            return v;
        }
    }
}
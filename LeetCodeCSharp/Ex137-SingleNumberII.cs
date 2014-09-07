/*
Given an array of integers, every element appears three 
times except for one. Find that single one. 

Note:
 Your algorithm should have a linear runtime complexity. 
 Could you implement it without using extra memory? 

 class Solution {
public:
    int singleNumber(int A[], int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex137
    {
        public static int SingleNumber(int[] A)
        {
            int[] x = new int[32];
            for(int i = 0; i < A.Length; i++)
                for(int j = 0; j < 32; j++) 
                {
                    x[j] += (A[i] >> j) & 1;
                    x[j] %= 3;
                }

            int res = 0;
            for(int i = 0; i < 32; i++) 
                res += x[i] << i;

            return res;
        }

        public static int SingleNumberA(int[] A)
        {
            int n1 = 0, n2 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int n0 = ~(n1 | n2);
                n2 = (n2 & ~A[i]) | (n1 & A[i]);
                n1 = (n1 & ~A[i]) | (n0 & A[i]);
            }

            return n1;
        }
    }
}
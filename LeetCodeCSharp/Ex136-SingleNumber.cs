/*
Given an array of integers, every element appears twice 
except for one. Find that single one.

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

    public class Ex136
    {
        public static int SingleNumber(int[] A)
        {
            int result = 0;
            for (int i = 0; i < A.Length; i++) 
                result ^= A[i];

            return result;
        }
    }
}
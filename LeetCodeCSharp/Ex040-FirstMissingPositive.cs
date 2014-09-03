/*
Given an unsorted integer array, find the first missing 
positive integer. 

For example,
 Given [1,2,0] return 3,
 and [3,4,-1,1] return 2. 

Your algorithm should run in O(n) time and uses constant
space. 

class Solution {
public:
    int firstMissingPositive(int A[], int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex040
    {
        public static int FirstMissingPositive(int[] A)
        {
            for (int i = 0; i < A.Length; ++i)
                if (A[i] > 0 && A[i] < A.Length)
                {
                    if (A[i]-1 != i && A[A[i]-1] != A[i])
                    {
                        int temp = A[A[i]-1];
                        A[A[i]-1] = A[i];
                        A[i] = temp;
                        i--;
                    }
                }

            for (int j = 0; j < A.Length; ++j)
                if (A[j]-1 != j) 
                    return j+1;

            return A.Length + 1;
        }
    }
}
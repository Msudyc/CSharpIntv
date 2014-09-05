/*
Follow up for "Remove Duplicates": What if duplicates are 
allowed at most twice?

For example,
 Given sorted array A = [1,1,1,2,2,3], 

Your function should return length = 5, and A is now [1,1,2,2,3]. 

class Solution {
public:
    int removeDuplicates(int A[], int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex080
    {
        public static int RemoveDuplicates(int[] A)
        {
            if (A.Length <= 2) 
                return A.Length;

            int cur = 1;
            for (int i = 2; i < A.Length; i++) 
            {
                if (!(A[i] == A[cur] && A[i] == A[cur - 1]))
                    A[++cur] = A[i];
            }

            return cur + 1;
        }
    }
}
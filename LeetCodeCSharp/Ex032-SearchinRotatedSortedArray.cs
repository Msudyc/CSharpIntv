/*
Suppose a sorted array is rotated at some pivot unknown 
to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

You are given a target value to search. If found in the 
array return its index, otherwise return -1.

You may assume no duplicate exists in the array.

class Solution {
public:
    int search(int A[], int n, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex032
    {
        public static int Search(int[] A, int target)
        {
            // cut half on every loop
            int l = 0, r = A.Length - 1;
            while (l <= r) 
            {
                int M = l + ((r - l) / 2); // Avoid overflow, same as M=(l+r)/2
                if (A[M] == target) 
                    return M;
                // the bottom half is sorted
                if (A[l] <= A[M]) 
                {
                    if (A[l] <= target && target < A[M]) 
                        r = M - 1;
                    else 
                        l = M + 1;
                }
                // the upper half is sorted
                else 
                {
                    if (A[M] < target && target <= A[r]) 
                        l = M + 1;
                    else 
                        r = M - 1;
                }
            }
        
            return -1;
        }
    }
}
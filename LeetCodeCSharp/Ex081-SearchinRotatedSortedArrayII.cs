/*
Follow up for "Search in Rotated Sorted Array": What if 
duplicates are allowed?

Would this affect the run-time complexity? How and why?

Write a function to determine if a given target is in the array.

class Solution {
public:
    bool search(int A[], int n, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex081
    {
        public static bool Search(int[] A, int n, int target)
        {
            int l = 0, r = n - 1;
            while (l <= r) 
            {
                int m = l + (r - l)/2;
                if (A[m] == target) 
                    return true; //return m in Search in Rotated Array I

                if (A[l] < A[m]) 
                { 
                    //left half is sorted
                    if (A[l] <= target && target < A[m]) 
                        r = m - 1;
                    else 
                        l = m + 1;
                } 
                else if (A[l] > A[m]) 
                { 
                    //right half is sorted
                    if (A[m] < target && target <= A[r]) 
                        l = m + 1;
                    else 
                        r = m - 1;
                } 
                else 
                    l++;
            }
        
            return false;
        }
    }
}
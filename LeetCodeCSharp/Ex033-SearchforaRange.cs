/*
Given a sorted array of integers, find the starting and 
ending position of a given target value.

Your algorithm's runtime complexity must be in the order 
of O(log n).

If the target is not found in the array, return [-1, -1].

For example,
 Given [5, 7, 7, 8, 8, 10] and target value 8,
 return [3, 4]. 

class Solution {
public:
    List<int> searchRange(int A[], int n, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex033
    {
        public static List<int> SearchRange(int[] A, int target)
        {
            List<int> range = new List<int>();
            range.Add(-1);
            range.Add(-1);

            int lower = 0, upper = A.Length - 1;
            int mid;

            // Search for lower bound
            while (lower < upper)
            {
                mid = (lower + upper) / 2;
                if (A[mid] < target)
                    lower = mid + 1; // critical
                else 
                    upper = mid;
            }

            // If the target is not found, return (-1, -1)
            if (A[lower] != target) 
                return range;
            range[0] = lower;

            // Search for upper bound
            upper = A.Length - 1;
            lower = lower == 0 ? 0 : lower-1;
            while (lower < upper) 
            {
                mid = (lower + upper)/2 + 1; // critical
                if (A[mid] > target)
                    upper = mid - 1; // critical
                else 
                    lower = mid;
            }

            range[1] = upper;
            return range;
        }
    }
}
/*
A peak element is an element that is greater than its neighbors.
Given an input array where num[i] ≠ num[i+1], find a peak element
and return its index. The array may contain multiple peaks, in 
that case return the index to any one of the peaks is fine.

You may imagine that num[-1] = num[n] = -∞.

For example, in array [1, 2, 3, 1], 3 is a peak element and your
function should return the index number 2.

Note: 
Your solution should be in logarithmic complexity.

class Solution {
public:
    int findPeakElement(const vector<int> &num) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex162
    {
        public static int FindPeakElement(int[] num)
        {
            int length = num.Length;
            if (length == 1)
                return 0;
            
            int mid = 0, low = 0, high = length - 1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if ((mid == 0 || num[mid] >= num[mid - 1])
                    && (mid == length - 1 || num[mid] >= num[mid + 1]))
                {
                    return mid;
                }
                else if (mid > 0 && num[mid - 1] >= num[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return mid;
        }
    }
}
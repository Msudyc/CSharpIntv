/*
Given an array S of n integers, find three integers in S such 
that the sum is closest to a given number, target. Return the 
sum of the three integers. You may assume that each input would 
have exactly one solution.

    For example, given array S = {-1 2 1 -4}, and target = 1.

    The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

class Solution {
public:
    int threeSumClosest(List<int> &num, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex016
    {
        public static int ThreeSumClosest(List<int> num, int target)
        {
            num.Sort();
            int n = num.Count, t, l, r, sum;
            if (n < 3)
                return 0;
            t = num[0] + num[1] + num[2];
            for (int i = 0; i < n - 2; i++)
            {
                l = i + 1; 
                r = n - 1;
                while (l < r)
                {
                    sum = num[i] + num[l] + num[r];
                    if (sum > target)
                        r--;
                    else if (sum < target)
                        l++;
                    else
                        return sum;

                    if (Math.Abs(sum - target) < Math.Abs(t - target))
                        t = sum;
                }
            }

            return t;
        }
    }
}
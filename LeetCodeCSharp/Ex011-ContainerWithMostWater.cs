/*
Given n non-negative integers a1, a2, ..., an, where each 
represents a point at coordinate (i, ai). n vertical lines 
are drawn such that the two endpoints of line i is at (i, ai) 
and (i, 0). Find two lines, which together with x-axis forms 
a container, such that the container contains the most water. 

Note: You may not slant the container. 

class Solution {
public:
    int maxArea(List<int> &height) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex011
    {
        public static int MaxAreaBF(List<int> height)
        {
            // brute force
            int n = height.Count;
            int smax = 0;

            for(int i = 0; i < n-1; i++)
                for(int j = i+1; j < n; j++)
                {
                    int s = Math.Min(height[j], height[i]) * (j-i);
                    smax = Math.Max(smax, s);
                }

            return smax;
        }

        public static int MaxArea(List<int> height)
        {
            // greedy
            int n = height.Count;
            int smax = 0;
            int i = 0, j = n - 1;
            while (i < j)
            {
                int s = Math.Min(height[j], height[i]) * (j - i);
                smax = Math.Max(smax, s);
                if (height[j] > height[i]) 
                    i++;
                else 
                    j--;
            }

            return smax;
        }
    }
}
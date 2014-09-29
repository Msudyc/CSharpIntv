/*
Implement int sqrt(int x). Compute and return the 
square root of x.

class Solution {
public:
    int sqrt(int x) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex069
    {
        public static int Sqrt(int x)
        {
            if (x <= 0)
                return 0;

            if (x == 1)
                return 1;

            int high = x;
            int low = 0;
            int mid;
            while (high - low > 1)
            {
                mid = low + (high - low) / 2;
                if (mid * mid <= x)
                    low = mid;
                else
                    high = mid;
            }

            return low;
        }
    }
}
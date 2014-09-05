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
            if (x == 0) 
                return 0;

            if (x == 1) 
                return 1;

            double x0 = 1;
            double x1;
            while (true)
            {
                x1 = (x0 + x / x0) / 2.0;
                if (Math.Abs(x1 - x0) < 1.0) 
                    return (int)x1;

                x0 = x1;
            }
        }
    }
}
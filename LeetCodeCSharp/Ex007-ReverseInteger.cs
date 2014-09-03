/*
Reverse digits of an integer.

Example1: x = 123, return 321
Example2: x = -123, return -321 

class Solution {
public:
    int reverse(int x) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex007
    {
        public static int Reverse(int x)
        {
            bool minus = false;
            if (x < 0) 
            { 
                minus = true; 
                x = -1 * x; 
            }

            int r = 0;
            while (x != 0)
            {
                r = r * 10 + (x % 10);
                x = x / 10;
            }

            if (minus) 
                r = r * (-1);

            return r;
        }
    }
}
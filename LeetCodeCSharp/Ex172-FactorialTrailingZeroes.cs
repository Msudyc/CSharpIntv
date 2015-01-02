/*
Given an integer n, return the number of trailing zeroes in n!.

Note: Your solution should be in logarithmic time complexity.

class Solution {
public:
    int trailingZeroes(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex172
    {
        public static int TrailingZeroes(int n)
        {
            int c = 0;
            while (n >= 5) 
            {
                n /= 5;
                c += n;
            }
            
            return c;
        }
    }
}
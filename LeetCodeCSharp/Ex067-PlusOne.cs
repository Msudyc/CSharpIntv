/*
Given a number represented as an array of digits, plus 
one to the number.

class Solution {
public:
    List<int> plusOne(List<int> &digits) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex067
    {
        public static List<int> PlusOne(List<int> digits)
        {
            int i;
            for (i = digits.Count - 1; i >= 0; i--)
            {
                if (digits[i] != 9) 
                { 
                    digits[i]++; 
                    return digits; 
                }
                else 
                    digits[i] = 0;
            }

            if (i < 0)
                digits.Insert(0, 1);
            return digits;
        }
    }
}
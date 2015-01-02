/*
Given a column title as appear in an Excel sheet, 
return its corresponding column number.

For example:
    A -> 1
    B -> 2
    C -> 3
    ...
    Z -> 26
    AA -> 27
    AB -> 28

class Solution {
public:
    int titleToNumber(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex171
    {
        public static int TitleToNumber(string s)
        {
            int res = 0;
            if (s.Length == 0)
                return 0;

            for (int i = 0; i < s.Length; ++i)
                res = res * 26 + s[i] - 'A' + 1;
            
            return res;
        }

        public static int TitleToNumberFromZero(string s)
        {
            int res = 0;
            if (s.Length == 0)
                return -1;

            for (int i = 0; i < s.Length; ++i)
                res = res * 26 + s[i] - 'A' + 1;

            return res - 1;
        }
    }
}
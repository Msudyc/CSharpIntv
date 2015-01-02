/*
Given two strings S and T, determine if they are 
both one edit distance apart.

class Solution {
public:
    bool isOneEditDistance(string s, string t) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex161
    {
        public static bool IsOneEditDistance(String s, String t)
        {
            if (s.Length < t.Length)
                return IsOneEditDistance(t, s);
            if (s.Length - t.Length > 1)
                return false;
            
            bool have = false;
            for (int i = 0, j = 0; i < t.Length; ++i, ++j)
                if (t[i] != s[j])
                {
                    if (have)
                        return false;
                    have = true;
                    if (s.Length > t.Length)
                        --i;
                }
            
            return have || (s.Length > t.Length);
        }
    }
}
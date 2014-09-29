/*
'?' Matches any single character.
'*' Matches any sequence of characters (including 
    the empty sequence).

The matching should cover the entire input string 
 (not partial).

The function prototype should be:
bool isMatch(const char *s, const char *p)

Some examples:
isMatch("aa","a") → false
isMatch("aa","aa") → true
isMatch("aaa","aa") → false
isMatch("aa", "*") → true
isMatch("aa", "a*") → true
isMatch("ab", "?*") → true
isMatch("aab", "c*a*b") → false

class Solution {
public:
    bool isMatch(const char *s, const char *p) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex043
    {
        public static bool IsMatch(string s, string p)
        {
            if (s == null || p == null)
                return false;

            if (s == p)
                return true;

            int pS = 0;
            int pP = 0;

            int pStar = -1;
            int pSBackTrack = -1;

            while (pS < s.Length)
            {
                if (pP < p.Length && (s[pS] == p[pP] || p[pP] == '?'))
                {
                    ++pS;
                    ++pP;
                }
                else if(pP < p.Length && p[pP] == '*')
                {
                    pStar = pP;
                    pSBackTrack = pS;
                    ++pP;
                }
                else if(pStar != -1)
                {
                    pS = pSBackTrack;
                    pP = pStar + 1;
                    ++pSBackTrack;
                }
                else
                    return false;
            }

            while(pP < p.Length && p[pP] == '*')
                ++pP;

            return pS == s.Length && pP == p.Length;
        }

        public static bool IsMatchR(string s, string p)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p))
                return string.IsNullOrEmpty(p) && string.IsNullOrEmpty(s);

            char fs = s[0];
            char fp = p[0];

            if (fp != '*')
                return (fs == fp || fp == '?') && IsMatchR(s.Substring(1), p.Substring(1));
            else
            {
                for (int i = 0; i <= s.Length; i++)
                    if (IsMatchR(s.Substring(i), p.Substring(1)))
                        return true;

                return false;
            }
        }
    }
}
/*
Implement regular expression matching with support 
for '.' and '*'.

'.' Matches any single character.
'*' Matches zero or more of the preceding element.

The matching should cover the entire input string 
(not partial).

The function prototype should be:
bool isMatch(const char *s, const char *p)

Some examples:
isMatch("aa","a") → false
isMatch("aa","aa") → true
isMatch("aaa","aa") → false
isMatch("aa", "a*") → true
isMatch("aa", ".*") → true
isMatch("ab", ".*") → true
isMatch("aab", "c*a*b") → true

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

    public class Ex010
    {
        public static bool IsMatch(string s, string p)
        {
            if (p.Length == 0)
                return s.Length == 0;

            //second char is not '*'
            if (p.Length == 1 || p[1] != '*')
            {
                if (s.Length < 1 || (s[0] != p[0] && p[0] != '.'))
                    return false;
                return IsMatch(s.Substring(1), p.Substring(1));
            }
            //second char is '*'
            else
            {
                int i = -1;
                while (i < s.Length && (i < 0 || p[0] == '.' || p[0] == s[0]))
                {
                    //tricky to back track
                    if (IsMatch(s.Substring(i + 1), p.Substring(2)))
                        return true;
                    i++;
                }

                return false;
            }
        }

        public static bool IsMatchDP(string s, string p)
        {
            // dp[i, j] => s[0->i-1] matches p[0->j-1]
            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;

            for (int i = 1; i <= p.Length; i++)
                if (p[i - 1] == '*')
                    if (i > 1)
                        dp[0, i] = dp[0, i - 2];

            for (int i = 1; i <= s.Length; i++)
                for (int j = 1; j <= p.Length; j++)
                {
                    if (p[j - 1] != '*')
                        dp[i, j] = dp[i - 1, j - 1] && (s[i - 1] == p[j - 1] || p[j - 1] == '.');
                    else
                        dp[i, j] = dp[i, j - 1] || (j >= 2 && dp[i, j - 2]) ||
                            (dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.'));
                }

            return dp[s.Length, p.Length];
        }
    }
}
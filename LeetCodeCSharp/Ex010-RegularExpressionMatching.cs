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
            if (string.IsNullOrEmpty(s)) 
                return string.IsNullOrEmpty(p);

            int slen = s.Length;
            int plen = p.Length;
            bool[,] dp = new bool[plen + 1, slen + 1];
            dp[0,0] = true;
            for(int i = 1; i <= plen; i++) 
            {
                switch(p[i-1]) 
                {
                case '*':
                    dp[i,0] = i > 1 ? dp[i-2,0] : false;
                    if(i < 2) 
                        continue;
                    if(p[i - 2] != '.')
                    {
                        for(int j = 1; j <= slen; j++)
                        {
                            if(dp[i-1,j] || (i >= 2 && dp[i-2,j]) || 
                                (j >= 2 && dp[i,j-1] && s[j-1] == s[j-2] && s[j-2] == p[i-2]))
                                dp[i,j] = true;
                        }
                    }
                    else
                    {
                        int j = 1;
                        while(!dp[i-2,j] && j <= slen && !dp[i-1,j]) 
                            j++;
                        for(; j <= slen; j++) 
                            dp[i,j] = true;
                    }
                    break;
                default :
                    for(int j = 1; j <= slen; j++) 
                        if(dp[i-1,j-1] && (s[j-1] == p[i-1] || p[i-1]=='.'))
                            dp[i,j] = true;
                    break;
                }
            }
        
            return dp[plen,slen];
        }
    }
}
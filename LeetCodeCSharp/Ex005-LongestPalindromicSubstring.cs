/*
Given a string S, find the longest palindromic substring in S. 
You may assume that the maximum length of S is 1000, and there 
exists one unique longest palindromic substring.

class Solution {
public:
    string longestPalindrome(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex005
    {
        public static string LongestPalindrome(string s)
        {
            // Brute force
            int N = s.Length;
            int start = 0, end = 0;
            if (N <= 1) return s;
            int i, j;
            for (i = 0; i < N; ++i) 
            {
                for (j = i+1; j < N; ++j) 
                {
                    if ((j-i+1 > end-start+1) && IsPalindrome(s, i, j)) 
                    {
                        start = i; 
                        end = j;
                    }
                }
            }
      
            return s.Substring(start, end-start+1);
        }
        
        private static bool IsPalindrome(string s, int i, int j)
        {
            while (i < j) 
            {
                if(s[i++] != s[j--]) return false;
            }
      
            return true;
        }

        public static string LongestPalindrome1(string s)
        {
            /* DP
            Define P[ i, j ] ← true if the substring Si ... Sj is a palindrome, otherwise false.
            P[ i, j ] ← ( P[ i+1, j-1 ] and Si = Sj )
            The base cases are:
                P[ i, i ] ← true
                P[ i, i+1 ] ← ( Si = Si+1 )
            */
            int n = s.Length, longestBegin = 0, maxLen = 1;
            bool[,] table = new bool[1000, 1000];
            for (int i = 0; i < n; i++) 
                table[i,i] = true;

            for (int i = 0; i < n-1; i++)
                if (s[i] == s[i+1])
                {
                    table[i,i+1] = true;
                    longestBegin = i;
                    maxLen = 2;
                }

            for (int len = 3; len <= n; len++) 
                for (int i = 0; i < n-len+1; i++)
                {
                    int j = i+len-1;
                    if (s[i] == s[j] && table[i+1,j-1]) 
                    {
                        table[i,j] = true;
                        longestBegin = i;
                        maxLen = len;
                    }
                }

            return s.Substring(longestBegin, maxLen);
        }

        public static string LongestPalindrome2(string s)
        {
            // Expand from center
            int n = s.Length;
            if (n == 0) 
                return "";
            string longest = s.Substring(0, 1);  // a single char itself is a palindrome
            for (int i = 0; i < n-1; i++) 
            {
                string p1 = expandAroundCenter(s, i, i);
                if (p1.Length > longest.Length) 
                    longest = p1;
                string p2 = expandAroundCenter(s, i, i+1);
                if (p2.Length > longest.Length) 
                    longest = p2;
            }

            return longest;
        }

        private static string expandAroundCenter(string s, int c1, int c2) 
        {
            int l = c1, r = c2, n = s.Length;
            while (l >= 0 && r <= n-1 && s[l] == s[r]) 
            { 
                l--; 
                r++; 
            }

            return s.Substring(l+1, r-l-1);
        }

        public static string LongestPalindrome3(string s)
        {
            string T = preProcess(s);
            int n = T.Length, C = 0, R = 0;
            int[] P = new int[n];
            for (int i = 1; i < n-1; i++) 
            {
                int i_mirror = 2*C-i; // equals to i' = C - (i-C)
                P[i] = (R > i) ? Math.Min(R-i, P[i_mirror]) : 0;
                // Attempt to expand palindrome centered at i
                while (T[i + 1 + P[i]] == T[i - 1 - P[i]]) P[i]++;
                // If palindrome centered at i expand past R,
                // adjust center based on expanded palindrome.
                if (i + P[i] > R) { C = i; R = i + P[i]; }
            } 
            // Find the maximum element in P.
            int maxLen = 0, centerIndex = 0;
            for (int i = 1; i < n-1; i++) 
            {
                if (P[i] > maxLen) { maxLen = P[i]; centerIndex = i; }
            }

            return s.Substring((centerIndex - 1 - maxLen)/2, maxLen);
        }

        private static string preProcess(string s) 
        {
            int n = s.Length;
            if (n == 0) return "^$";
            string ret = "^";
            for (int i = 0; i < n; i++) ret += "#" + s.Substring(i, 1); 
            ret += "#$";
            return ret;
        }
    }
}
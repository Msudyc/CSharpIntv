/*
Given a string s, partition s such that every substring
of the partition is a palindrome. Return the minimum cuts 
needed for a palindrome partitioning of s. 

For example, given s = "aab",Return 1 since the palindrome
partitioning ["aa","b"] could be produced using 1 cut. 

class Solution {
public:
    int minCut(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex132
    {
        public static int MinCut(string s)
        {
            int len = s.Length;
            int[] dp = new int[len + 1];
            bool[,] palin = new bool[len, len];

            for(int i = 0; i <= len; i++) 
                dp[i] = len - i;

            for(int i = len-1; i >= 0; i--)
                for(int j = i; j < len; j++)
                    if(s[i] == s[j] && (j-i < 2 || palin[i+1, j-1]))
                    {
                        palin[i, j] = true;
                        dp[i] = Math.Min(dp[i], dp[j+1] + 1);
                    }
                
            return dp[0] - 1;
        }

        public static int MinCut1(string s)
        {
            bool[,] Palindrome = GetPalindrome(s);
            int[] dp = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (Palindrome[0, i] == true)
                    dp[i] = 0;
                else
                {
                    int min = s.Length - 1;
                    for (int j = 0; j < i; j++)
                        if (Palindrome[j + 1, i] == true && dp[j] + 1 < min)
                            min = dp[j] + 1;
                    dp[i] = min;
                }
            }

            return dp[s.Length - 1];
        }

        public static bool[,] GetPalindrome(string str)
        {
            int n = str.Length;
            bool[,] dp = new bool[n, n];

            for (int j = 0; j < n; j++)
                for (int i = j; i >= 0; i--)
                {
                    if (str[j] == str[i] && (j - i < 2 || dp[i + 1, j - 1]))
                        dp[i, j] = true;
                }

            return dp;
        }
    }
}
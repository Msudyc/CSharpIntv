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
    }
}
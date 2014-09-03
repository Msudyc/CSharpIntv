/*
Given a string, find the length of the longest substring without 
repeating characters. For example, the longest substring without 
repeating letters for "abcabcbb" is "abc", which the length is 3. 
For "bbbbb" the longest substring is "b", with the length of 1.

class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex003
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int maxLen = 0;
            int n = s.Length;
            int j = 0;
            bool[] hash = new bool[256];

            for(int i = 0; i < n; i++)
            {
                if(hash[s[i]])
                {
                    maxLen = Math.Max(maxLen, i - j);
                    while (s[j] != s[i])
                    {
                        hash[s[j]] = false;
                        j++;
                    }

                    j++;
                }
                else
                    hash[s[i]] = true;
            }

            maxLen = Math.Max(maxLen, n - j);
            return maxLen;
        }
    }
}
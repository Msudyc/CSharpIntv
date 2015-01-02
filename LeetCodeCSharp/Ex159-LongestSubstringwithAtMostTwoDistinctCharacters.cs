/*
Given a string, find the length of the longest substring T 
that contains at most 2 distinct characters. 

For example, Given s = “eceba”, 

T is "ece" which its length is 3. 

class Solution {
public:
    int lengthOfLongestSubstringTwoDistinct(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex159
    {
        public static int lengthOfLongestSubstringTwoDistinct(String s)
        {
            int i = 0, j = -1, maxLen = 0;
            for (int k = 1; k < s.Length; k++)
            {
                if (s[k] == s[k - 1])
                    continue;
                if (j >= 0 && s[j] != s[k])
                {
                    maxLen = Math.Max(k - i, maxLen);
                    i = j + 1;
                }
                
                j = k - 1;
            }
            
            return Math.Max(s.Length - i, maxLen);
        }
    }
}
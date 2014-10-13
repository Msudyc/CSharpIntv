/*
Write a function to find the longest common prefix string 
amongst an array of strings. 

class Solution {
public:
    string longestCommonPrefix(List<string> &strs) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex014
    {
        public static string LongestCommonPrefix(List<string> strs)
        {
            // brute force O(mn)
            if (strs.Count == 0)
                return string.Empty;
            if (strs.Count == 1)
                return strs[0];

            string str = strs[0];
            for (int i = 0; i < str.Length; i++)
                for (int j = 1; j < strs.Count; j++)
                    if (strs[j].Length < i + 1 || strs[j][i] != str[i])
                        return str.Substring(0, i);
            return str;
        }
    }
}
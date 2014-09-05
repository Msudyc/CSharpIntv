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
            if (strs.Count == 0) return "";
            for (int i = 0; i < strs[0].Length; i++)
                for (int j = 1; j < strs.Count; j++)
                    if (strs[j][i] != strs[0][i]) return strs[0].Substring(0, i);
            return strs[0];
        }
    }
}
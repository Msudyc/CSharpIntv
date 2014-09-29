/*
Returns a pointer to the first occurrence of needle in 
haystack, or null if needle is not part of haystack. 

class Solution {
public:
    char *strStr(char *haystack, char *needle) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex027
    {
        public static string StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return haystack;

            for (int i = 0; i < haystack.Length; i++)
                if (Match(haystack, i, needle))
                    return haystack.Substring(i);

            return null;
        }

        private static bool Match(string haystack, int i, string needle)
        {
            for (int j = 0; j < needle.Length; j++)
                if (needle[j] != haystack[i + j])
                    return false;

            return true;
        }
    }
}
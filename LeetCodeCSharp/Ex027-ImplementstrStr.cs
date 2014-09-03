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

            int start = 0;
            int i1 = 0;
            int i2 = 0;
            while (i1 < haystack.Length && i2 < needle.Length)
            {
                if (haystack[i1] == needle[i2])
                {
                    i1++;
                    i2++;
                }
                else
                {
                    start++;
                    i1 = start;
                    i2 = 0;
                }
            }

            if (i2 == needle.Length && (i1 - start) == needle.Length)
                return haystack.Substring(start);
            else
                return null;
        }
    }
}
/*
Given a string s consists of upper/lower-case alphabets and 
empty space characters ' ', return the length of last word 
in the string.

If the last word does not exist, return 0.

Note: A word is defined as a character sequence consists of 
non-space characters only.

For example, 
 Given s = "Hello World",
 return 5. 

class Solution {
public:
    int lengthOfLastWord(const char *s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex057
    {
        public static int LengthOfLastWord(string s)
        {
            int l = 0;
            int k = 0;
            while (k < s.Length)
            {
                if (s[k++] != ' ')
                    l++;
                // s already move to next char
                else if (k < s.Length && s[k] != ' ')
                    l = 0;
            }

            return l;
        }
    }
}
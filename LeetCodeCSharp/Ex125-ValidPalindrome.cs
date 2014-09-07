/*
Given a string, determine if it is a palindrome, considering
only alphanumeric characters and ignoring cases. 

For example,
"A man, a plan, a canal: Panama" is a palindrome.
"race a car" is not a palindrome. 

Note:
 Have you consider that the string might be empty? 
 This is a good question to ask during an interview.

For the purpose of this problem, we define empty string as
valid palindrome.

class Solution {
public:
    bool isPalindrome(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex125
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (!IsAlphaNumeric(s[i])) 
                    i++;
                else if (!IsAlphaNumeric(s[j])) 
                    j--;
                else if (s[i++] != s[j--]) 
                    return false;
            }

            return true;
        }

        private static bool IsAlphaNumeric(char c)
        {
            if (c >= '0' && c <= '9' || c >= 'a' && c <= 'z') 
                return true;
            else 
                return false;
        }
    }
}
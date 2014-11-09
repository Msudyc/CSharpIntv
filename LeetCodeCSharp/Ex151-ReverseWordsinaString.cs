/*
Given an input string, reverse the string word by word. 

For example,
 Given s = "the sky is blue",
 return "blue is sky the". 
 
public class Solution {
    public String reverseWords(String s) {
        
    }
}
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Ex151
    {
        public static string ReverseWords(string s)
        {
            StringBuilder reversed = new StringBuilder();
            int j = s.Length;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                    j = i;
                else if (i == 0 || s[i - 1] == ' ')
                {
                    if (reversed.Length != 0)
                        reversed.Append(' ');

                    reversed.Append(s.Substring(i, j - i));
                }
            }

            return reversed.ToString();
        }
    }
}
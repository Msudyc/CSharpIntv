/*
Given a digit string, return all possible letter combinations 
that the number could represent. 

A mapping of digit to letters (just like on the telephone buttons) 
is given below.

1-"" 2-abc 3-def 4-ghi 5-jkl 6-mno 7-pqrs 8-tuv 9-wxyz 

Input:Digit string "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].


Note:
 Although the above answer is in lexicographical order, your 
 answer could be in any order you want.

class Solution {
public:
    List<string> letterCombinations(string digits) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex018
    {
        public static List<string> LetterCombinations(string digits)
        {
            string[] dict = { "", "", "abc", "def", "ghi", "jkl", "mno", "qprs", "tuv", "wxyz" };
            List<string> result = new List<string>();
            result.Add("");
            for (int i = 0; i < (int)digits.Length; i++)
            {
                string s = dict[digits[i] - '0'];
                List<string> tmp = new List<string>();
                for (int j = 0; j < (int)s.Length; j++)
                    for (int k = 0; k < (int)result.Count; k++)
                        tmp.Add(result[k] + s[j]);
                result = tmp;
            }

            return result;
        }
    }
}
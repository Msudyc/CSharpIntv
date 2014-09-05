/*
Given two words word1 and word2, find the minimum number 
of steps required to convert word1 to word2. (each operation
is counted as 1 step.) 

You have the following 3 operations permitted on a word: 

a) Insert a character
b) Delete a character
c) Replace a character

class Solution {
public:
    int minDistance(string word1, string word2) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex072
    {
        public static int MinDistance(string word1, string word2)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;
            int[,] table = new int[len1 + 1, len2 + 1];   
            for (int i = 1; i <= len1; i++) 
                table[i, 0] = i;         
            for (int j = 1; j <= len2; j++) 
                table[0, j] = j;
         
            for(int i = 0; i < len1; i++)
                for (int j = 0; j < len2; j++)
                {                         
                    table[i+1, j+1] = Math.Min(table[i+1, j], table[i, j+1]) + 1;
                    if (word1[i] == word2[j]) 
                        table[i+1, j+1] = Math.Min(table[i+1, j+1], table[i, j]);
                    else 
                        table[i+1, j+1] = Math.Min(table[i+1, j+1], table[i, j] + 1);
                }
         
            return table[len1, len2];
        }
    }
}
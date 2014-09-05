/*
Given s1, s2, s3, find whether s3 is formed by the 
interleaving of s1 and s2. 

For example,
 Given:
s1 = "aabcc",
s2 = "dbbca", 

When s3 = "aadbbcbcac", return true.
 When s3 = "aadbbbaccc", return false. 

class Solution {
public:
    bool isInterleave(string s1, string s2, string s3) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex097
    {
        public static bool IsInterleave(string s1, string s2, string s3)
        {
            int n1 = s1.Length, n2 = s2.Length;
            bool[,] A = new bool[n1+1, n2+1];

            if (n1+n2 != s3.Length) 
                return false; 

            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2) && string.IsNullOrEmpty(s3)) 
                return true;
          
            A[0, 0] = true;    
            for (int i = 1; i <= n1; i++)
                if (s1[i-1] == s3[i-1] && A[i-1, 0]) 
                    A[i, 0] = true;

            for (int i=1;i<=n2;i++)
                if (s2[i-1] == s3[i-1] && A[0, i-1]) 
                    A[0, i] = true;
                  
            for (int i = 1; i <= n1; i++)
                for (int j = 1; j <= n2; j++)
                    A[i, j] = (A[i, j-1] && (s2[j-1]==s3[i+j-1])) || (A[i-1, j] && (s1[i-1]==s3[i+j-1])); 

            return A[n1, n2];
        }
    }
}
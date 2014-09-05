/*
Given n, how many structurally unique BST's (binary 
search trees) that store values 1...n?

For example,
 Given n = 3, there are a total of 5 unique BST's. 

   1         3     3      2      1
    \       /     /      / \      \
     3     2     1      1   3      2
    /     /       \                 \
   2     1         2                 3

class Solution {
public:
    int numTrees(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex095
    {
        public static int NumTrees(int n)
        {
            int[] table = new int[n+1];
            if (n <= 1) 
                return n;

            table[0] = 1; 
            table[1] = 1; 
            table[2] = 2;
            for (int i=3; i<=n; i++)
            {
                int res=0;
                for (int j=0; j<=i-1;j ++)
                {
                    res = res + table[j] * table[i-1-j];
                }

                table[i]=res;
            }

            return table[n];
        }
    }
}
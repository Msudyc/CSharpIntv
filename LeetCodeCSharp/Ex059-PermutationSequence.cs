/*
The set [1,2,3,�,n] contains a total of n! unique 
 permutations.

By listing and labeling all of the permutations in 
order, We get the following sequence (ie, for n = 3): 

1."123"
2."132"
3."213"
4."231"
5."312"
6."321"

Given n and k, return the kth permutation sequence.

Note: Given n will be between 1 and 9 inclusive.

class Solution {
public:
    string getPermutation(int n, int k) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex059
    {
        public static string GetPermutation(int n, int k)
        {
            char[] arr = new char[n];
            int pro = 1;
            for(int i = 0 ; i < n; ++i) 
            {
                arr[i] = (char)('1' + i);
                pro *= (i + 1);
            }

            k = k - 1;
            k %= pro;

            pro /= n; //pro = 1 * 2 * ... * (n-1)
            for(int i = 0 ; i < n-1; ++i) 
            {
                //for index i
                int selectI = k / pro;
                k = k % pro;
                pro /= (n - i - 1);
                char temp = arr[selectI + i];
                for(int j = selectI; j > 0; --j)
                    arr[i + j] = arr[i + j - 1];
                arr[i] = temp;
            }

            return new string(arr);
        }
    }
}
/*
Given an array and a value, remove all instances of 
that value in place and return the new length. 

The order of elements can be changed. It doesn't matter 
what you leave beyond the new length. 

class Solution {
public:
    int removeElement(int A[], int n, int elem) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex026
    {
        public static int RemoveElement(int[] A, int elem)
        {
            int k = 0;
            for (int i = 0; i < A.Length; i++)
                if (A[i] != elem)
                    A[k++] = A[i];
            return k;
        }
    }
}
/*
There are two sorted arrays A and B of size m and n respectively. 
Find the median of the two sorted arrays. The overall run time 
complexity should be O(log (m+n)).

class Solution {
public:
    double findMedianSortedArrays(int A[], int m, int B[], int n) {
        
    }
};
*/

/*
Median of n elements in an array of A[0..n-1] is
if n is odd,  median = A[n/2]
if n is even, median = (A[n/2] + A[n/2-1]) / 2
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex002
    {
        public static double FindMedianSortedArrays(int[] A, int m, int[] B, int n)
        {
            int total = m + n;
            if(total%2 == 1) 
                return Fms(A, 0, m, B, 0, n, total/2 + 1);
            else 
                return (Fms(A, 0, m, B, 0, n, total/2) + Fms(A, 0, m, B, 0, n, total/2 + 1))/2;
        }

        private static double Fms(
            int[] A, int sa, int m, int[] B, int sb, int n, int k)
        {
            if (m > n) 
                return Fms(B, sb, n, A, sa, m, k);

            if (m == 0) 
                return B[sb + k - 1];

            if (k == 1) 
                return Math.Min(A[sa], B[sb]);

            int pa = Math.Min(k/2, m);
            int pb = k - pa;
            if (A[sa + pa - 1] <= B[sb + pb - 1]) 
                return Fms(A, sa + pa, m - pa, B, sb, n, k - pa);
            else
                return Fms(A, sa, m, B, sb + pb, n - pb, k - pb);
        }
    }
}
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
            if ((m + n) % 2 == 1)
                return Fms(A, 0, m - 1, B, 0, n - 1, (m + n) / 2);
            else
                return (Fms(A, 0, m - 1, B, 0, n - 1, (m + n) / 2 - 1) + 
                    Fms(A, 0, m - 1, B, 0, n - 1, (m + n) / 2)) / 2.0;
        }

        public static int Fms(
            int[] A, int sa, int ea, int[] B, int sb, int eb, int k)
        {
            int lenA = ea - sa + 1;
            int lenB = eb - sb + 1;

            if (lenA == 0)
                return B[sb + k];

            if (lenB == 0)
                return B[sa + k];

            if (k == 0)
                return A[sa] < B[sb] ? A[sa] : B[sb];

            int pa = k * lenA / (lenA + lenB);
            int pb = k - pa - 1;

            int ia = pa + sa;
            int ib = pb + sb;

            if (A[ia] > B[ib])
            {
                k = k - (ib - sb + 1);
                ea = ia;
                sb = ib + 1;
            }
            else
            {
                k = k - (ia - sa + 1);
                eb = ib;
                sa = ia + 1;
            }

            return Fms(A, sa, ea, B, sb, eb, k);
        }
    }
}
/* Question 11.1
 
You are given two sorted arrays, A and B, where A has a large enough buffer at the end 
to hold B. Write a method to merge B in A in sorted order. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter11_Q01
    {
        public static void Merge(int[] a, int[] b, int lenA)
        {
            Merge(a, b, lenA, b.Length);
        }

        private static void Merge(int[] a, int[] b, int lastA, int lastB)
        {
            int indexA = lastA - 1;
            int indexB = lastB - 1;
            int indexMerged = lastA + lastB - 1;

            while (indexA >= 0 && indexB >= 0)
            {
                if (a[indexA] > b[indexB])
                    a[indexMerged--] = a[indexA--];
                else
                    a[indexMerged--] = b[indexB--];
            }

            while (indexB >= 0)
                a[indexMerged--] = b[indexB--];
        }
    }
}

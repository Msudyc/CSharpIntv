/* Question 17.6
 
Given an array of integers, write a method to find indices m and n such that if you sorted
elements m through n, the entire array would be sorted. Minimize n - m (that is, find the
smallest such sequence).
Example:
Input: 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19
output: (3, 9)
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q06
    {
        public static Tuple<int, int> Find(int[] array)
        {
            int endLeft = FindEndOfLeftSubsequence(array);
            int startRight = FindStartOfRightSubsequence(array);

            int min = endLeft + 1;
            if (min >= array.Length)
                return null;
            int max = startRight - 1;
            for (int i = endLeft; i <= startRight; i++)
            {
                if (array[i] < array[min])
                    min = i;
                if (array[i] > array[max])
                    max = i;
            }

            int left = ShrinkLeft(array, min, endLeft);
            int right = ShrinkRight(array, max, startRight);
            return new Tuple<int, int>(left, right);
        }

        private static int FindEndOfLeftSubsequence(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
                if (array[i] < array[i - 1])
                    return i - 1;
            return array.Length - 1;
        }

        private static int FindStartOfRightSubsequence(int[] array)
        {
            for (int i = array.Length - 2; i >= 0 ; i--)
                if (array[i] > array[i + 1])
                    return i + 1;
            return 0;
        }

        private static int ShrinkLeft(int[] array, int minIdex, int start)
        {
            int comp = array[minIdex];
            for (int i = start - 1; i >= 0; i--)
                if (array[i] <= comp)
                    return i + 1;
            return 0;
        }

        private static int ShrinkRight(int[] array, int maxIdex, int start)
        {
            int comp = array[maxIdex];
            for (int i = start; i < array.Length; i++)
                if (array[i] >= comp)
                    return i - 1;
            return array.Length - 1;
        }
    }
}

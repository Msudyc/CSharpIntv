/* Question 9.3
 
A magic index in an array[0...n-1] is defined to be an index such that A[i] = i. 
Given a sorted array, write a method to find a magic index, if one exists, in array A.
Follow up:
What if the values are not distinct?
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q03
    {
        public static int MagicFast(int[] array)
        {
            return MagicFast(array, 0, array.Length - 1);
        }

        public static int MagicFastNotDistinct(int[] array)
        {
            return MagicFastNotDistinct(array, 0, array.Length - 1);
        }

        private static int MagicFast(int[] array, int start, int end)
        {
            if (end < start || start < 0 || end >= array.Length)
                return -1;

            int mid = (start + end) / 2;
            if (array[mid] == mid)
                return mid;
            else if (array[mid] > mid)
                return MagicFast(array, start, mid - 1);
            else
                return MagicFast(array, mid + 1, end);
        }

        private static int MagicFastNotDistinct(int[] array, int start, int end)
        {
            if (end < start || start < 0 || end >= array.Length)
                return -1;

            int mid = (start + end) / 2;
            int midValue = array[mid];
            if (midValue == mid)
                return mid;
            
            int leftIndex = Math.Min(mid - 1, midValue);
            int left = MagicFastNotDistinct(array, start, leftIndex);
            if (left >= 0)
                return left;

            int rightIndex = Math.Max(mid + 1, midValue);
            int right = MagicFastNotDistinct(array, rightIndex, end);
            return right;
        }
    }
}

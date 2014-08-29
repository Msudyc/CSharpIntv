/* Question 18.6
 
Describe an algorithm to find the smallest one million numbers in one billion numbers. 
Assume that the computer memory can hold all one billion numbers. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q06
    {
        public static int FindRank(int[] array, int rank)
        {
            if (rank >= array.Length)
                return -1;
            return Rank(array, 0, array.Length - 1, rank);
        }

        private static int Rank(int[] array, int left, int right, int rank)
        {
            int pivot = array[new Random().Next(right - left) + left];
            int leftEnd = Partition(array, left, right, pivot);
            int leftSize = leftEnd - left + 1;
            if (leftSize == rank + 1)
                return FindMax(array, left, leftEnd);
            else if (rank < leftSize)
                return Rank(array, left, leftEnd, rank);
            else
                return Rank(array, leftEnd + 1, right, rank - leftSize);
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            while(true)
            {
                while(left <= right && array[left] <= pivot)
                    left++;

                while(left <= right && array[right] > pivot)
                    right--;

                if(left > right)
                    return left - 1;

                Swap(array, left, right);
            }
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        private static int FindMax(int[] arr, int left, int right)
        {
            int max = int.MinValue;
            for (int i = left; i <= right; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
    }
}

/* Question 11.6
 
Given an MxN matrix in which each row and each column is sorted in ascending order. 
Write a method to find an element. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter11_Q06
    {
        public static bool FindElement(int[,] array, int elem)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int low = 0;
            int high = rows * cols - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid / cols, mid % cols] == elem) return true;
                else if (array[mid / cols, mid % cols] < elem) low = mid + 1;
                else if (array[mid / cols, mid % cols] > elem) high = mid - 1;
            }

            return false;
        }
    }
}

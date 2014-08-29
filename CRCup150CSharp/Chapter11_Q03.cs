/* Question 11.3
 
Given a sorted array of n integers that has been rotated an unknown number of times, 
write code to find an element in the array. You may assume that the array was originally
sorted in increasing order. 
Sample;
Input: find 5 in {15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14}
Output: 8 (the index of 5 in the array)

 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter11_Q03
    {
        // distinct number
        public static int Search(int[] array, int x)
        {
            int l = 0;
            int r = array.Length - 1;

            while (l <= r)
            {
                // Avoid overflow, same as mid=(l+r)/2
                int mid = l + ((r - l) / 2); 
                if (array[mid] == x) 
                    return mid;

                // the bottom half is sorted
                if (array[l] <= array[mid])
                {
                    if (array[l] <= x && x < array[mid]) 
                        r = mid - 1;
                    else 
                        l = mid + 1;
                }
                // the upper half is sorted
                else
                {
                    if (array[mid] < x && x <= array[r]) 
                        l = mid + 1;
                    else 
                        r = mid - 1;
                }
            }

            return -1;
        }
    }
}

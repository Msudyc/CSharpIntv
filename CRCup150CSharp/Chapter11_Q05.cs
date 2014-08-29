/* Question 11.5
 
Given a sorted array of strings which is interspersed with empty strings, write a method
to find the location of a given string.
Example:
Input: find "ball" in {"at", "", "", "", "ball", "", "","car", "", "", "dad", "", ""}
Output: 4
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter11_Q05
    {
        public static int Search(string[] array, string word)
        {
            int l = 0;
            int r = array.Length - 1;

            while (l <= r)
            {
                int mid = l + ((r - l) / 2);
                if (string.IsNullOrEmpty(array[mid]))
                {
                    int left = mid - 1;
                    int right = mid + 1;
                    while (true)
                    {
                        if (left < l && right > r)
                            return -1;
                        else if (right <= r && !string.IsNullOrEmpty(array[right]))
                        {
                            mid = right;
                            break;
                        }
                        else if (left <= l && !string.IsNullOrEmpty(array[left]))
                        {
                            mid = left;
                            break;
                        }

                        right++;
                        left--;
                    }
                }

                if (array[mid] == word)
                    return mid;
                else if (string.Compare(array[mid], word, true) < 0)
                    l = mid + 1;
                else
                    r = mid - 1;
            }
            
            return -1;
        }
    }
}

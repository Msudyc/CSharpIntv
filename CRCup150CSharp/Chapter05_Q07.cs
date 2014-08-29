/* Question 5.7
 
An array A contains all the integers from 0 to n, except from one number which is missing. 
In this problem, we cannot access an entire integer in A with a single operation. The 
elements of A are represented in binary, and the only operation we can use to access them
is "fetch the jth bit of A[i]," which takes constant time. Write code to find the missing 
integer. Can you do it in O(n) time? 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter05_Q07
    {
        public static int FindMissing(List<int> array)
        {
            return FindMissing(array, 0);
        }

        private static int FindMissing(List<int> input, int column)
        {
            if (column > 31)
                return 0;

            List<int> oneBits = new List<int>(input.Count / 2);
            List<int> zeroBits = new List<int>(input.Count / 2);

            foreach (int n in input)
            {
                if (FindBit(n, column) == 0)
                    zeroBits.Add(n);
                else
                    oneBits.Add(n);
            }

            if (zeroBits.Count <= oneBits.Count)
            {
                int v = FindMissing(zeroBits, column + 1);
                return v << 1 | 0;
            }
            else
            {
                int v = FindMissing(oneBits, column + 1);
                return v << 1 | 1;
            }
        }

        private static int FindBit(int n, int column)
        {
            return (n >> column) & 0x1;
        }
    }
}

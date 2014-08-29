/* Question 9.9
 
Write an algorithm to print all ways of arranging eight queens on an 8x8 chess 
board so that none of them share the same row, column or diagonal. In this case,
"diagonal" means all diagonals, not just the two that bisect the board. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q09
    {
        public static List<int[]> PlaceQueues(int n)
        {
            List<int[]> result = new List<int[]>();
            int[] temp = new int[n];
            PlaceQueues(result, temp, 0);
            return result;
        }

        private static void PlaceQueues(List<int[]> result, int[] temp, int cur)
        {
            if (cur == temp.Length)
            {
                int[] a = new int[temp.Length];
                temp.CopyTo(a, 0);
                result.Add(a);
            }
            else
            {
                for(int i=0; i<temp.Length;i++)
                {
                    if(IsValid(temp, cur, i))
                    {
                        temp[cur] = i;
                        PlaceQueues(result, temp, cur + 1);
                    }
                }
            }
        }

        private static bool IsValid(int[] temp, int cur, int v)
        {
            for (int i = 0; i < cur; i++)
            {
                if (v == temp[i]) return false;
                else if (Math.Abs(v - temp[i]) == Math.Abs(i - cur))
                    return false;
            }

            return true;
        }
    }
}

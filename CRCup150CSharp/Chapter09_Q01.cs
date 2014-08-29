/* Question 9.1
 
A child is running up a staircase with n steps, and can hop either 1 step, 2 steps or 3 steps 
at a time. Implement a method to count how many possible ways the child can run up the stairs. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q01
    {
        public static int CountWaysDP(int n)
        {
            int[] temp = new int[n+1];
            return CountWaysDP(n, temp);
        }

        private static int CountWaysDP(int n, int[] map)
        {
            if (n < 0)
                return 0;
            else if (n == 0)
                return 1;
            else if (map[n] > 0)
                return map[n];
            else
            {
                map[n] = CountWaysDP(n - 1, map) +
                    CountWaysDP(n - 2, map) +
                    CountWaysDP(n - 3, map);
                return map[n];
            }
        }
    }
}

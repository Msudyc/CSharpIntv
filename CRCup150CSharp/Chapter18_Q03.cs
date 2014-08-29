/* Question 18.3
 
Write a method to randomly generate a set of m integers from an array of size n. 
Each element must have equal probability of being chosen. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q03
    {
        public static int[] PickMRandomly(int[] original, int m)
        {
            int[] subset = new int[m];
            int[] array = new int[original.Length];
            original.CopyTo(array, 0);
            for (int j = 0; j < m; j++)
            {
                int index = Rand(j, array.Length - 1);
                subset[j] = array[index];
                array[index] = array[j]; // array[j] is dead now
            }

            return subset;
        }

        private static int Rand(int lower, int higher)
        {
            return lower + new Random().Next(higher - lower + 1);
        }
    }
}

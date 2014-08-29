/* Question 1.7
 
Write an algorithm such that if an element in an MxN matrix is 0, 
its entir row and column are set to 0. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q07
    {
        public static void SetZeros(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            bool[] rows = new bool[m];
            bool[] cols = new bool[n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] == 0)
                    {
                        rows[i] = true;
                        cols[j] = true;
                    }

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (rows[i] || cols[j])
                        matrix[i, j] = 0;
        }
    }
}

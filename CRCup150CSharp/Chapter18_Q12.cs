/* Question 18.12
 
Given an NxN matrix of positive and negative integers, write code to find the submatrix 
with the largest possible sum. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q12
    {
        public static int GetMaxMatric(int[,] original)
        {
            int[,] matrix = PreCompute(original);
            int maxArea = int.MinValue;
            int rowCount = original.GetLength(0);
            int colCount = original.GetLength(1);

            for (int r1 = 0; r1 < rowCount; r1++)
                for (int r2 = r1; r2 < rowCount; r2++)
                    for (int c1 = 0; c1 < colCount; c1++)
                        for (int c2 = c1; c2 < colCount; c2++)
                            maxArea = Math.Max(
                                maxArea,
                                ComputeSum(matrix, r1, r2, c1, c2));
            return maxArea;
        }

        private static int ComputeSum(int[,] subMatrix, int i1, int i2, int j1, int j2)
        {
            if (i1 == 0 && j1 == 0)
                return subMatrix[i2, j2];
            else if (i1 == 0)
                return subMatrix[i2, j2] - subMatrix[i2, j1 - 1];
            else if (j1 == 0)
                return subMatrix[i2, j2] - subMatrix[i1 - 1, j2];
            else
                return subMatrix[i2, j2] - subMatrix[i2, j1 - 1] 
                    - subMatrix[i1 - 1, j2] + subMatrix[i1 - 1, j1 - 1];
        }

        private static int[,] PreCompute(int[,] matrix)
        {
            int lenR = matrix.GetLength(0);
            int lenC = matrix.GetLength(1);
            int[,] subMatrix = new int[lenR, lenC];

            for (int i = 0; i < lenR; i++)
                for (int j = 0; j < lenC; j++)
                {
                    if (i == 0 && j == 0)
                        subMatrix[i, j] = matrix[i, j];
                    else if (j == 0)
                        subMatrix[i, j] = subMatrix[i - 1, j] + matrix[i, j];
                    else if (i == 0)
                        subMatrix[i, j] = subMatrix[i, j - 1] + matrix[i, j];
                    else
                        subMatrix[i, j] = subMatrix[i - 1, j] + subMatrix[i, j - 1]
                            - subMatrix[i - 1, j - 1] + matrix[i, j];
                }

            return subMatrix;
        }
    }
}

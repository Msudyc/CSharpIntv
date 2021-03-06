﻿/* Question 1.6
 
 Given an image represented by and NxN matrix, where each pixel in the image is 4 bytes,
 write a method to rotate the image by 90 degrees. Can you do this in place?
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q06
    {
        public static void Rotate(int[,] matrix, int n)
        {
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = layer; i < n - layer - 1; i++)
                {
                    int offset = i - first;
                    //top
                    int temp = matrix[first, i];
                    //left to top
                    matrix[first, i] = matrix[last - offset, first];
                    //bottom to left
                    matrix[last - offset, first] = matrix[last, last - offset];
                    //right to bottom
                    matrix[last, last - offset] = matrix[i, last];
                    //top to right
                    matrix[i, last] = temp;
                }
            }
        }

        public static void Rotate2(int[,] matrix, int n)
        {
            for (int i = 0; i < n / 2; i++)
                for (int j = 0; j < n; j++)
                    Swap(matrix, i, j, n - 1 - i, j);

            for (int i = 0; i < n; i++)
                for (int j = 0; j <= i; j++)
                    Swap(matrix, i, j, j, i);
        }

        private static void Swap(int[,] matrix, int a, int b, int x, int y)
        {
            int temp = matrix[a, b];
            matrix[a, b] = matrix[x, y];
            matrix[x, y] = temp;
        }
    }
}

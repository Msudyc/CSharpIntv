/* Question 18.11
 
Imagine you have square matrix, where each cell (pixel) is either black or white. 
Design an algorithm to find the maximum subsquare such that all four borders are
filled with black pixels. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q11
    {
        public static SubSquare FindSquare(int[,] matrix)
        {
            SquareCell[,] processed = Process(matrix);
            int len = matrix.GetLength(0);
            for (int i = len; i >= 1; i--)
            {
                SubSquare square = FindSquareWithSize(processed, i);
                if (square != null)
                    return square;
            }

            return null;
        }

        private static SubSquare FindSquareWithSize(SquareCell[,] matrix, int size)
        {
            int count = matrix.GetLength(0) - size + 1;
            for(int row = 0; row < count; row++)
                for(int col = 0; col < count; col++)
                    if(IsSquare(matrix, row, col, size))
                        return new SubSquare()
                        {
                            Row = row,
                            Col = col,
                            Size = size
                        };

            return null;
        }

        private static bool IsSquare(SquareCell[,] matrix, int row, int col, int size)
        {
            SquareCell topleft = matrix[row, col];
            SquareCell topright = matrix[row, col + size - 1];
            SquareCell bottomleft = matrix[row + size - 1, col];
            if (topleft.ZerosRight < size)
                return false;
            if (topleft.ZerosBelow < size)
                return false;
            if (topright.ZerosBelow < size)
                return false;
            if (bottomleft.ZerosRight < size)
                return false;

            return true;
        }

        private static SquareCell[,] Process(int[,] matrix)
        {
            int len = matrix.GetLength(0);
            SquareCell[,] result = new SquareCell[len, len];

            for (int r = len - 1; r >= 0; r--)
            {
                for (int c = len - 1; c >= 0; c--)
                {
                    int rightZeros = 0;
                    int belowZeros = 0;
                    if (matrix[r, c] == 0)
                    {
                        rightZeros++;
                        belowZeros++;
                        if (c + 1 < len)
                        {
                            SquareCell pre = result[r, c + 1];
                            rightZeros += pre.ZerosRight;
                        }
                        if (r + 1 < len)
                        {
                            SquareCell pre = result[r + 1, c];
                            belowZeros += pre.ZerosBelow;
                        }
                    }

                    result[r, c] = new SquareCell()
                    {
                        ZerosRight = rightZeros,
                        ZerosBelow = belowZeros
                    };
                }
            }

            return result;
        }

        public class SubSquare
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public int Size { get; set; }
        }

        private class SquareCell
        {
            internal int ZerosRight { get; set; }
            internal int ZerosBelow { get; set; }
        }
    }
}

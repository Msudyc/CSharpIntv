/*
Write a program to solve a Sudoku puzzle by filling the 
empty cells. Empty cells are indicated by the character
'.'.

You may assume that there will be only one unique solution. 

class Solution {
public:
    void solveSudoku(List<List<char> > &board) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex036
    {
        public static void SolveSudoku(char[,] board)
        {
            SolveSudokudfs(board);
        }

        private static bool SolveSudokudfs(char[,] board)
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (board[i, j] == '.')
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            board[i, j] = (char)('0' + k);
                            if (IsValid(board, i, j) && SolveSudokudfs(board))
                                return true;
                            board[i, j] = '.';
                        }

                        return false;
                    }

            return true;
        }

        private static bool IsValid(char[,] board, int a, int b)
        {
            for (int i = 0; i < 9; i++)
                if (i != a && board[i, b] == board[a, b]) 
                    return false;

            for (int j = 0; j < 9; j++)
                if (j != b && board[a, j] == board[a, b]) 
                    return false;

            int x = a / 3 * 3, y = b / 3 * 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (x + i != a && y + j != b && board[x + i, y + j] == board[a, b])
                        return false;
            return true;
        }
    }
}
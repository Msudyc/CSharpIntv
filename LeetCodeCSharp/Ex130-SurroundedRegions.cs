/*
Given a 2D board containing 'X' and 'O', capture all regions
surrounded by 'X'. A region is captured by flipping all 'O's 
into 'X's in that surrounded region . 

For example,

X X X X
X O O X
X X O X
X O X X

After running your function, the board should be: 
X X X X
X X X X
X X X X
X O X X

class Solution {
public:
    void solve(List<List<char>> &board) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex130
    {
        public static void Solve(char[,] board)
        {
            int m = board.GetLength(0);
            if (m == 0) 
                return;

            int n = board.GetLength(1);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (i == 0 || (i == m - 1) || j == 0 || (j == n - 1))
                        Mark(board, i, j);

            Flip(board, 'O', 'X');
            Flip(board, 'M', 'O');
        }

        private static void Mark(char[,] board, int row, int col)
        {
            int m = board.GetLength(0);
            int n = board.GetLength(1);

            if (board[row, col] != 'O') 
                return;
            else 
                board[row, col] = 'M';

            if (row > 0) 
                Mark(board, row - 1, col);

            if (row < m - 1) 
                Mark(board, row + 1, col);

            if (col > 0) 
                Mark(board, row, col - 1);

            if (col < n - 1) 
                Mark(board, row, col + 1);
        }

        private static void Flip(char[,] board, char from, char to)
        {
            int m = board.GetLength(0);
            int n = board.GetLength(1);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (board[i, j] == from) 
                        board[i, j] = to;
        }
    }
}
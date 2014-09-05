/*
Given a 2D board and a word, find if the word exists in 
the grid. 

The word can be constructed from letters of sequentially
adjacent cell, where "adjacent" cells are those horizontally
or vertically neighboring. The same letter cell may not be 
used more than once. 

For example,
 Given board = 
[
  ["ABCE"],
  ["SFCS"],
  ["ADEE"]
]

word = "ABCCED", . returns true,
word = "SEE", . returns true,
word = "ABCB", . returns false.

*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex079
    {
        public static bool Exist(char[,] board, string word)
        {
            for (int i = 0; i < board.GetLength(0); i++)
                for (int j = 0; j < board.GetLength(1); j++)
                    if (DFS(board, word, 0, i, j)) 
                        return true;
            return false;
        }

        private static bool DFS(char[,] board, string word, int index, int x, int y)
        {
            if (index == word.Length - 1 && word[index] == board[x, y])
                return true;

            if (word[index] != board[x, y])
                return false;

            char tmp = board[x, y];
            board[x, y] = '.';

            bool b1 = false, b2 = false, b3 = false, b4 = false;
            if (x - 1 >= 0 && board[x - 1, y] != '.')
                b1 = DFS(board, word, index + 1, x - 1, y);

            if (!b1 && y - 1 >= 0 && board[x, y - 1] != '.')
                b2 = DFS(board, word, index + 1, x, y - 1);

            if (!b1 && !b2 && x + 1 < board.GetLength(0) && board[x + 1, y] != '.')
                b3 = DFS(board, word, index + 1, x + 1, y);

            if (!b1 && !b2 && !b3 && y + 1 < board.GetLength(1) && board[x, y + 1] != '.')
                b4 = DFS(board, word, index + 1, x, y + 1);

            board[x, y] = tmp;
            return b1 || b2 || b3 || b4;
        }
    }
}
/*
Determine if a Sudoku is valid, according to: Sudoku Puzzles.

The Sudoku board could be partially filled, where empty cells 
are filled with the character '.'.

class Solution {
public:
    bool isValidSudoku(List<List<char> > &board) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex035
    {
        public static bool IsValidSudoku(char[,] board)
        {
            //true -- number already used
            bool[,] rows = new bool[9,9];;
            bool[,] cols = new bool[9,9];;
            bool[,] blocks = new bool[9, 9]; ;

            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j) 
                {
                    if (board[i,j] == '.') 
                        continue;
                    int c = board[i,j] - '1';
                    if (rows[i,c] || cols[j,c] || blocks[i - i % 3 + j / 3,c])
                        return false;
                    rows[i,c] = cols[j,c] = blocks[i - i % 3 + j / 3,c] = true;
                }

            return true;
        }
    }
}
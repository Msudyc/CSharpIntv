/* Question 17.2
 
Design an algorithm to figure out if someone has won a game of tic-tac-toe. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q02
    {
        public enum Piece { Empty, Red, Blue }
        public static Piece HasWon(Piece[,] board)
        {
            int N = board.GetLength(0);
            int row = 0;
            int col = 0;

            // check rows
            for (row = 0; row < N; row++)
            {
                if (board[row, 0] != Piece.Empty)
                {
                    for (col = 1; col < N; col++)
                        if (board[row, col] != board[row, col-1])
                            break;
                    if (col == N)
                        return board[row, 0];
                }
            }

            // check columns
            for (col = 0; col < N; col++)
            {
                if (board[0, col] != Piece.Empty)
                {
                    for (row = 1; row < N; row++)
                        if (board[row, col] != board[row-1, col])
                            break;
                    if (row == N)
                        return board[0, col];
                }
            }

            // check diagonal top left to bottom right
            if (board[0, 0] != Piece.Empty)
            {
                for (row = 1; row < N; row++)
                    if (board[row, row] != board[row-1, row-1])
                        break;
                if (row == N)
                    return board[0, 0];
            }

            // check diagonal bottom left to top right
            if (board[N-1, 0] != Piece.Empty)
            {
                for (row = 1; row < N; row++)
                    if (board[N-row-1, row] != board[N-row, row-1])
                        break;
                if (row == N)
                    return board[N-1, 0];
            }

            return Piece.Empty;
        }
    }
}

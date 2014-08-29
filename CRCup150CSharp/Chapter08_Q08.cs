/* Question 8.8
 
Othello is played as follows: Each Othello piece is white on one side and black on the other. 
When a piece is surrounded by its opponents on both the left and right sides, or both the top
and bottom, it is said to be captured and its color is flipped. On your turn, you must capture
at least one of your opponent's pieces. The game ends when either user has no more valid moves.
The win is assigned to the person with the most pieces. Implement the OO design for Othello. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q08
    {
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        public enum Color
        {
            White,
            Black
        }

        public class Game
        {
            private List<Player> players = new List<Player>();
            private static Game instance;
            private Board board = new Board(Rows, Cols);
            private const int Rows = 10;
            private const int Cols = 10;

            private Game()
            {
                players.Add(new Player());
                players.Add(new Player());
                players[0].Color = Color.White;
                players[1].Color = Color.Black;
            }

            public static Game GetInstance()
            {
                if (instance == null)
                    instance = new Game();
                return instance;
            }

            public Board Getboard()
            {
                return this.board;
            }
        }

        public class Board
        {
            private List<List<Piece>> board = new List<List<Piece>>();

            public Board(int r, int c)
            {
            }

            public bool PlaceColor(int r, int c, Color color)
            {
                throw new NotImplementedException();
            }

            public int GetScoreForColor(Color c)
            {
                throw new NotImplementedException();
            }

            private int FlipSection(int r, int c, Color color, Direction d)
            {
                throw new NotImplementedException();
            }
        }

        public class Piece
        {
            public Color Color { get; set; }

            public void Flip()
            {
            }
        }

        public class Player
        {
            public Color Color { get; set; }

            public int GetScore()
            {
                throw new NotImplementedException();
            }

            public bool PlayPiece(int r, int c)
            {
                throw new NotImplementedException();
            }
        }
    }
}

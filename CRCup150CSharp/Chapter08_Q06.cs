/* Question 8.6
 
Implement a jigsaw puzzle. Design the data structures and explain an algorithm to solve the puzzle.
You can assume that you have a fitsWith method wihch, when passed two puzzle pieces, returns true 
if the two pieces belong together. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q06
    {
        public class Edge
        {
            public enum TypeEnum
            {
                Inner,
                Outer,
                Flat
            }

            public Piece Parent { get; set; }
            public TypeEnum Type { get; set; }
            public int Index { get; set; }
            public Edge AttachedTo { get; set; }

            public bool FitsWith(Edge edge)
            {
                throw new NotImplementedException();
            }
        }

        public class Piece
        {
            public List<Edge> Edges { get; set; }
            public bool IsCorner { get; set; }
        }

        public class Puzzle
        {
            private List<Piece> pieces = new List<Piece>();
            private List<List<Piece>> solution = new List<List<Piece>>();
            private List<Edge> Innsers = new List<Edge>();
            private List<Edge> Outers = new List<Edge>();
            private List<Edge> Flats = new List<Edge>();

            public void Sort()
            {
            }

            public void Solve()
            {
            }
        }
    }
}

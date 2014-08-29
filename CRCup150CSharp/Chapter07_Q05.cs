/* Question 7.5
 
Given two squares on a two-dimensional plane, find a line that would cut these two 
squares in half. Assume that the top and the bottom sides of the square run parallel to the x-axis. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter07_Q05
    {
        // top bottom parallel to the x-axis
        public class SpecialSquare
        {
            public Point TopLeft { get; set; }
            public int Length { get; set; }

            public Point GetMiddle()
            {
                return new Point(
                    this.TopLeft.X + this.Length / 2,
                    this.TopLeft.Y + this.Length / 2);
            }

            public Line Cut(SpecialSquare other)
            {
                Point s = this.GetMiddle();
                Point e = other.GetMiddle();
                if (s == e)
                {
                    SpecialSquare bigger = this.Length > other.Length ? this : other;
                    return new Line(
                        bigger.TopLeft,
                        new Point(
                            bigger.TopLeft.X + bigger.Length,
                            bigger.TopLeft.Y + bigger.Length));
                }
                else
                    return new Line(s, e);

            }
        }

        public class Line
        {
            public Line(Point s, Point e)
            {
                this.Start = s;
                this.End = e;
            }

            public Point Start { get; set; }
            public Point End { get; set; }
        }

        public class Point
        {
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            public static bool operator == (Point p1, Point p2)
            {
                return p1.X == p2.X && p1.Y == p2.Y;
            }

            public static bool operator != (Point p1, Point p2)
            {
                return p1.X != p2.X || p1.Y != p2.Y;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                Point p = obj as Point;
                if (p == null)
                    return false;
                else
                    return p == this;
            }
        }
    }
}

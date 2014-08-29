/* Question 7.6
 
Given a two-dimensional graph with points on it, find a line which passes the most number of points. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter07_Q06
    {
        public static Line FindBestLine(List<Point> points)
        {
            Line baseLine = null;
            Dictionary<Line, int> map = new Dictionary<Line, int>(
                new LineEqualityComparer());
            for(int i =0; i< points.Count;i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    Line line = new Line(points[i], points[j]);
                    if (!map.ContainsKey(line))
                        map.Add(line, 0);
                    
                    map[line]++;
                    if (baseLine == null || map[line] > map[baseLine])
                        baseLine = line;
                }
            }

            return baseLine;
        }

        #region Util
        public class Line
        {
            private const double Epsilon = 0.0001;

            public Line(Point p1, Point p2)
            {
                if (Math.Abs(p1.X - p2.X) > Epsilon)
                {
                    this.Slope = (p1.Y - p2.Y) / (p1.X - p2.X);
                    this.YIntercept = p1.Y - this.Slope * p1.X;
                }
                else
                {
                    this.InfiniteSlope = true;
                    this.YIntercept = p1.X;
                }
            }

            public double Slope { get; set; }
            public double YIntercept { get; set; }
            public bool InfiniteSlope { get; set; }

            public static bool operator == (Line l1, Line l2)
            {
                if (ReferenceEquals(l1, l2))
                {
                    return true;
                }

                if (((object)l1 == null) || ((object)l2 == null))
                {
                    return false;
                }

                return l1.Slope == l2.Slope &&
                    l1.YIntercept == l2.YIntercept &&
                    l1.InfiniteSlope == l2.InfiniteSlope;
            }

            public static bool operator != (Line l1, Line l2)
            {
                return !(l1 == l2);
            }

            public override bool Equals(object obj)
            {
                Line l = obj as Line;
                if ((object)l == null)
                {
                    return false;
                }

                return base.Equals(obj) && this == l;
            }

            public override int GetHashCode()
            {
                return this.Slope.GetHashCode() ^
                    this.YIntercept.GetHashCode() ^
                    this.InfiniteSlope.GetHashCode();
            }
        }

        class LineEqualityComparer : IEqualityComparer<Line>
        {
            public bool Equals(Line l1, Line l2)
            {
                return l1 == l2;
            }

            public int GetHashCode(Line l)
            {
                return l.GetHashCode();
            }
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
        }
        #endregion
    }
}

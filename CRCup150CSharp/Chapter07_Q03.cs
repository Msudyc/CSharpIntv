/* Question 7.3
 
Given two lines on a Cartesian plane, determine whether the two lines would intersect. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter07_Q03
    {
        public class Line
        {
            private const double Epsilon = 0.000001;
            public double Slope { get; set; }
            public double YIntercept { get; set; }

            public bool Intersect(Line line2)
            {
                return Math.Abs(this.Slope - line2.Slope) > Epsilon ||
                    Math.Abs(this.YIntercept - line2.YIntercept) > Epsilon;
            }
        }
    }
}

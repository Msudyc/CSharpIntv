/* Question 9.10
 
You have a stack of n boxes, with widths wi, heights hi, and depths di. 
The boxes cannot be rotated and can only be stacked on top of one another
if each box in the stack is strictly larger than the box above it in with,
height, and depth. Implement a method to build the tallest stack possible,
where the height of a stack is the sum of the heights of each box. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q10
    {
        public static List<Box> CreateStackDP(List<Box> boxes)
        {
            Dictionary<Box, List<Box>> map = new Dictionary<Box,List<Box>>();
            return CreateStackDP(boxes, null, map);
        }

        private static List<Box> CreateStackDP(
            List<Box> boxes, 
            Box bottom,
            Dictionary<Box, List<Box>> map)
        {
            if (bottom != null && map.ContainsKey(bottom))
                return map[bottom];

            int maxHeight = 0;
            List<Box> maxStack = null;
            for (int i = 0; i < boxes.Count; i++)
                if (boxes[i].CanBeAbove(bottom))
                {
                    List<Box> newStack = CreateStackDP(boxes, boxes[i], map);
                    int newHeight = StackHeight(newStack);
                    if (newHeight > maxHeight)
                    {
                        maxHeight = newHeight;
                        maxStack = newStack;
                    }
                }

            if (maxStack == null)
                maxStack = new List<Box>();
            if (bottom != null)
                maxStack.Add(bottom);
            if(bottom != null)
                map.Add(bottom, maxStack);
            return maxStack;
        }

        private static int StackHeight(List<Box> boxes)
        {
            int height = 0;
            foreach (Box b in boxes)
                height += b.Height;
            return height;
        }

        public class Box
        {
            public Box(int d, int h, int w)
            {
                this.Width = w;
                this.Height = h;
                this.Depth = d;
            }

            public int Width { get; set; }
            public int Height { get; set; }
            public int Depth { get; set; }

            public bool CanBeAbove(Box box)
            {
                if (box == null)
                    return true;

                return this.Height < box.Height &&
                    this.Width < box.Width &&
                    this.Depth < box.Depth;
            }
        }
    }
}

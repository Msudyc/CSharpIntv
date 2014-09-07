using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex120Test
    {
        [TestMethod]
        public void LeetCode_Ex120_Test_MinimumTotal1()
        {
            List<List<int>> t = new List<List<int>>();
            List<int> r0 = new List<int>(); 
            r0.Add(2);
            List<int> r1 = new List<int>(); 
            r1.Add(3); 
            r1.Add(4);
            List<int> r2 = new List<int>(); 
            r2.Add(6); 
            r2.Add(5); 
            r2.Add(7);
            List<int> r3 = new List<int>(); 
            r3.Add(4); 
            r3.Add(1); 
            r3.Add(8); 
            r3.Add(3);

            t.Add(r0); 
            t.Add(r1); 
            t.Add(r2); 
            t.Add(r3);

            Assert.AreEqual(11, Ex120.MinimumTotal(t));
        }
    };
}
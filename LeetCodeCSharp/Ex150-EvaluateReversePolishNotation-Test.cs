using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex150Test
    {
        [TestMethod]
        public void LeetCode_Ex150_Test_EvalRPN1()
        {
            List<string> t = new List<string>();
            t.Add("2");
            t.Add("1");
            t.Add("+");
            t.Add("3");
            t.Add("*");
            Assert.AreEqual(9, Ex150.EvalRPN(t));
        }

        [TestMethod]
        public void LeetCode_Ex150_Test_EvalRPN2()
        {
            List<string> t = new List<string>();
            t.Add("4");
            t.Add("13");
            t.Add("5");
            t.Add("/");
            t.Add("+");
            Assert.AreEqual(6, Ex150.EvalRPN(t));
        }
    };
}
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex126Test
    {
        [TestMethod]
        public void LeetCode_Ex126_Test_LadderLength1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            Assert.AreEqual(5, Ex126.LadderLength("hit", "cog", dict));
        }

        [TestMethod]
        public void LeetCode_Ex126_Test_LadderLength2()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            Assert.AreEqual(2, Ex126.LadderLength("hit", "hit", dict));
        }

        [TestMethod]
        public void LeetCode_Ex126_Test_LadderLength3()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            Assert.AreEqual(2, Ex126.LadderLength("hit", "hot", dict));
        }
    };
}
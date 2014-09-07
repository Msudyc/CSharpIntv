using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex127Test
    {
        [TestMethod]
        public void LeetCode_Ex127_Test_FindLadders1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            List<List<string>> res = Ex127.FindLadders("hit", "cog", dict);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex127_Test_FindLadders2()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            List<List<string>> res = Ex127.FindLadders("abc", "cog", dict);
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex127_Test_FindLadders3()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            List<List<string>> res = Ex127.FindLadders("cog", "cog", dict);
            Assert.AreEqual(1, res.Count);
        }
    };
}
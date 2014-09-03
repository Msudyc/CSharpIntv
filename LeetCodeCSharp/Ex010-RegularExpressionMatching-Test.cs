using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex010Test
    {
        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatch1()
        {
            Assert.IsFalse(Ex010.IsMatch("aa", "a"));
            Assert.IsFalse(Ex010.IsMatch("aaa", "aa"));
            Assert.IsTrue(Ex010.IsMatch("aa", "aa"));
            Assert.IsTrue(Ex010.IsMatch("aa", "a*"));
            Assert.IsTrue(Ex010.IsMatch("aa", ".*"));
            Assert.IsTrue(Ex010.IsMatch("ab", ".*"));
            Assert.IsTrue(Ex010.IsMatch("aab", "c*a*b"));
            Assert.IsFalse(Ex010.IsMatch("aab", "ddc*a*b"));
            Assert.IsFalse(Ex010.IsMatch("", "c"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatch2()
        {
            Assert.IsTrue(Ex010.IsMatch("abcdxyzda", "a.*da"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatch3()
        {
            Assert.IsTrue(Ex010.IsMatch("abcdxyzdakadyda", "a.*da"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatch4()
        {
            Assert.IsFalse(Ex010.IsMatch("abcdxyzdakadyd", "a.*da"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatch5()
        {
            Assert.IsTrue(Ex010.IsMatch("abcdxyzdakadyd", "a.*da.*"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatch6()
        {
            Assert.IsFalse(Ex010.IsMatch("abcdxyzdakadyda", "a.*da.*d"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatch7()
        {
            Assert.IsTrue(Ex010.IsMatch("abcdayzdakadaxxdattd", "a.*da.*d"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatch8()
        {
            Assert.IsFalse(Ex010.IsMatch("abcdayzdakadaxxdattda", "a.*da.*d"));
        }

        //---

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA1()
        {
            Assert.IsFalse(Ex010.IsMatchDP("aa", "a"));
            Assert.IsFalse(Ex010.IsMatchDP("aaa", "aa"));
            Assert.IsTrue(Ex010.IsMatchDP("aa", "aa"));
            Assert.IsTrue(Ex010.IsMatchDP("aa", "a*"));
            Assert.IsTrue(Ex010.IsMatchDP("aa", ".*"));
            Assert.IsTrue(Ex010.IsMatchDP("ab", ".*"));
            Assert.IsTrue(Ex010.IsMatchDP("aab", "c*a*b"));
            Assert.IsFalse(Ex010.IsMatchDP("aab", "ddc*a*b"));
            Assert.IsFalse(Ex010.IsMatchDP("", "c"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA2()
        {
            Assert.IsTrue(Ex010.IsMatchDP("abcdxyzda", "a.*da"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA3()
        {
            Assert.IsTrue(Ex010.IsMatchDP("abcdxyzdakadyda", "a.*da"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA4()
        {
            Assert.IsFalse(Ex010.IsMatchDP("abcdxyzdakadyd", "a.*da"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA5()
        {
            Assert.IsTrue(Ex010.IsMatchDP("abcdxyzdakadyd", "a.*da.*"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA6()
        {
            Assert.IsFalse(Ex010.IsMatchDP("abcdxyzdakadyda", "a.*da.*d"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA7()
        {
            Assert.IsTrue(Ex010.IsMatchDP("abcdayzdakadaxxdattd", "a.*da.*d"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA8()
        {
            Assert.IsFalse(Ex010.IsMatchDP("abcdayzdakadaxxdattda", "a.*da.*d"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA9()
        {
            Assert.IsTrue(Ex010.IsMatchDP("aaa", "a*a"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA10()
        {
            Assert.IsTrue(Ex010.IsMatchDP("aaa", "ab*a*c*a"));
        }

        [TestMethod]
        public void LeetCode_Ex010_Test_IsMatchA11()
        {
            Assert.IsFalse(Ex010.IsMatchDP("*", "*"));
        }
    };
}
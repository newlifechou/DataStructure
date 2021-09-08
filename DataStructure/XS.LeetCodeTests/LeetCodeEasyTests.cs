using Microsoft.VisualStudio.TestTools.UnitTesting;
using XS.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.LeetCode.Tests
{
    [TestClass()]
    public class LeetCodeEasyTests
    {
        [TestMethod()]
        public void TwoSum1Test()
        {
            LeetCodeEasy lc = new LeetCodeEasy();
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            var result = lc.TwoSum1(nums, target);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod()]
        public void TwoSum2Test()
        {
            LeetCodeEasy lc = new LeetCodeEasy();
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            var result = lc.TwoSum1(nums, target);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasic.Tests
{
    [TestClass()]
    public class SimpleDataTests
    {
        [TestMethod()]
        public void GetOrderedArrayTest()
        {
            SimpleData simpleData = new SimpleData();
            var result = simpleData.GetOrderedArray(10);

            Assert.AreEqual(10, result.Length);
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(i, result[i]);
            }
        }
    }
}
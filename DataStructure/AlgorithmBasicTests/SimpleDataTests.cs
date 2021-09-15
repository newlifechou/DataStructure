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

        [TestMethod()]
        public void SuffleTest()
        {
            SimpleData simpleData = new SimpleData();
            var result1 = simpleData.GetOrderedArray(10);
            var result2 = simpleData.GetOrderedArray(10);
            simpleData.Shuffle(result2);

            bool isSame = true;
            for (int i = 0; i < 10; i++)
            {
                isSame = isSame && (result1[i] == result2[2]);
            }

            Assert.IsFalse(isSame);

        }

        [TestMethod()]
        public void ThrowExceptionTest1()
        {
            SimpleData data = new SimpleData();
            var ex1 = Assert.ThrowsException<Exception>(() => data.ThrowException(true));
            Assert.AreEqual(ex1.Message, "YES");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException),"")]
        public void ThrowExceptionTest2()
        {
            SimpleData data = new SimpleData();
            data.ThrowException(false);
        }

    }
}
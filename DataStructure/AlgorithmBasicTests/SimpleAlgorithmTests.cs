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
    public class SimpleAlgorithmTests
    {
        [TestMethod()]
        public void GetLeastCommonMutipleTest1()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int a = 7;
            int b = 5;
            int expected = 35;

            int result = simple.GetLeastCommonMutiple(a, b);

            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void GetLeastCommonMutipleTest2()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int a = 10;
            int b = 2;
            int expected = 10;

            int result = simple.GetLeastCommonMutiple(a, b);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetLargestCommonVidisorTest1()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int a = 9;
            int b = 3;
            int expected = 3;

            int result = simple.GetLargestCommonVidisor(a, b);

            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void GetLargestCommonVidisorTest2()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int a = 15;
            int b = 5;
            int expected = 5;

            int result = simple.GetLargestCommonVidisor(a, b);

            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void GetLargestCommonVidisorTest3()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int a = 21;
            int b = 14;
            int expected = 7;

            int result = simple.GetLargestCommonVidisor(a, b);

            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void FibonacciTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            Assert.AreEqual(1, simple.Fibonacci(0));
            Assert.AreEqual(1, simple.Fibonacci(1));
            Assert.AreEqual(2, simple.Fibonacci(2));
            Assert.AreEqual(3, simple.Fibonacci(3));
            Assert.AreEqual(5, simple.Fibonacci(4));
            Assert.AreEqual(8, simple.Fibonacci(5));
            Assert.AreEqual(13, simple.Fibonacci(6));
        }
    }
}
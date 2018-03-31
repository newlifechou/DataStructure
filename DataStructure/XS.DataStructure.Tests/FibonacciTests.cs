using Microsoft.VisualStudio.TestTools.UnitTesting;
using XS.DataStructure.StackQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        private Fibonacci fibs;
        [TestInitialize]
        public void Initialize()
        {
            fibs = new Fibonacci();
        }
        [TestMethod()]
        public void FibTest()
        {
            Assert.AreEqual(0, fibs.Fib(0));
            Assert.AreEqual(1, fibs.Fib(1));
            Assert.AreEqual(1, fibs.Fib(2));
            Assert.AreEqual(2, fibs.Fib(3));
            Assert.AreEqual(3, fibs.Fib(4));
            Assert.AreEqual(5, fibs.Fib(5));
            Assert.AreEqual(8, fibs.Fib(6));
        }
    }
}
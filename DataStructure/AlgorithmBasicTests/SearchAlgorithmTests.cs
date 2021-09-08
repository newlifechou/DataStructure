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
    public class SearchAlgorithmTests
    {
        [TestMethod()]
        public void BinarySearchTest()
        {
            SearchAlgorithm algorithm = new SearchAlgorithm();
            int[] numbers = new SimpleData().GetOrderedArray(1000);
            int number = 333;
            int index = algorithm.BinarySearch(numbers, number);
            Assert.AreEqual(333, index);
        }

        [TestMethod()]
        public void StupidSearchTest()
        {
            SearchAlgorithm algorithm = new SearchAlgorithm();
            int[] numbers = new SimpleData().GetOrderedArray(1000);
            int number = 333;
            int index = algorithm.BinarySearch(numbers, number);
            Assert.AreEqual(333, index);
        }
    }
}
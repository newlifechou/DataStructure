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
            Assert.AreEqual(1, simple.Fibonacci(1));
            Assert.AreEqual(1, simple.Fibonacci(2));
            Assert.AreEqual(2, simple.Fibonacci(3));
            Assert.AreEqual(3, simple.Fibonacci(4));
            Assert.AreEqual(5, simple.Fibonacci(5));
            Assert.AreEqual(8, simple.Fibonacci(6));
        }

        [TestMethod()]
        public void MaxTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            SimpleData data = new SimpleData();
            var nums = data.GetOrderedArray(10);
            data.Shuffle(nums);

            var result = simple.Max(nums);
            Assert.AreEqual(9, result.Item2);

        }

        [TestMethod()]
        public void FactorialTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            var result = simple.Factorial(10);
            var expected = 3628800;

            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void RecursionSumTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int[] nums = new int[100];
            for (int i = 0; i < 100; i++)
            {
                nums[i] = i + 1;
            }
            var result = simple.RecursionSum(nums);

            int expected = 5050;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RecursionCountTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int[] nums = new int[100];
            for (int i = 0; i < 100; i++)
            {
                nums[i] = i + 1;
            }
            var result = simple.RecursionCount(nums);

            int expected = 100;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RecursionMaxTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int[] nums = new int[100];
            for (int i = 0; i < 100; i++)
            {
                nums[i] = i + 1;
            }
            SimpleData data = new SimpleData();
            data.Shuffle(nums);

            var result = simple.RecursionMax(nums);

            int expected = 100;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void FindSecondMaxTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int[] nums = new int[100];
            for (int i = 0; i < 100; i++)
            {
                nums[i] = i + 1;
            }
            SimpleData data = new SimpleData();
            data.Shuffle(nums);

            var result = simple.FindSecondMax(nums);

            int expected = 99;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsPrimeTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();

            Assert.IsTrue(simple.IsPrime(1));
            Assert.IsTrue(simple.IsPrime(2));
            Assert.IsTrue(simple.IsPrime(3));
            Assert.IsFalse(simple.IsPrime(4));
            Assert.IsTrue(simple.IsPrime(5));
            Assert.IsFalse(simple.IsPrime(6));
            Assert.IsTrue(simple.IsPrime(7));
            Assert.IsFalse(simple.IsPrime(8));
            Assert.IsFalse(simple.IsPrime(9));


        }

        [TestMethod()]
        public void GetPrimePairTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            var result1 = simple.GetPrimePair(8);
            Assert.AreEqual(3, result1.Item1);
            Assert.AreEqual(5, result1.Item2);

            var result2 = simple.GetPrimePair(7);
            Assert.IsNull(result2);

        }

        [TestMethod()]
        public void IsLeapYearTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            Assert.IsTrue(simple.IsLeapYear(1880));
            Assert.IsTrue(simple.IsLeapYear(2008));
            Assert.IsTrue(simple.IsLeapYear(2012));
            Assert.IsTrue(simple.IsLeapYear(2016));
            Assert.IsTrue(simple.IsLeapYear(2020));
        }

        [TestMethod()]
        public void GetDaysByDateTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();

            Assert.AreEqual(31, simple.GetDaysByDate(new DateTime(2021, 1, 31)));
            Assert.AreEqual(59, simple.GetDaysByDate(new DateTime(2021, 2, 28)));
            Assert.AreEqual(362, simple.GetDaysByDate(new DateTime(2021, 12, 28)));
        }

        [TestMethod()]
        public void Fish_CountTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int result = simple.Fish_Count1();
            Assert.AreEqual(3121, result);
        }

        [TestMethod()]
        public void Fish_Count2Test()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int result = simple.Fish_Count2(5);
            Assert.AreEqual(3121, result);
        }

        [TestMethod()]
        public void DiuFanTu_AgeTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int result = simple.DiuFanTu_Age();
            Assert.AreEqual(84, result);
        }

        [TestMethod()]
        public void IsPalindromicSubStringTest()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            string s1 = "hellolleh";
            bool result1 = simple.IsPalindromicSubString(s1);
            Assert.IsTrue(result1);

            string s2 = "helloworld";
            bool result2 = simple.IsPalindromicSubString(s2);
            Assert.IsFalse(result2);


        }
    }
}
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

            int result = simple.ShowLeastCommonMutiple(a, b);

            Assert.AreEqual(expected,result);
        }


        [TestMethod()]
        public void GetLeastCommonMutipleTest2()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int a = 10;
            int b = 2;
            int expected = 10;

            int result = simple.ShowLeastCommonMutiple(a, b);

            Assert.AreEqual(expected, result);
        }


    }
}
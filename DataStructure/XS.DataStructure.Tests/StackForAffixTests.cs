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
    public class StackForAffixTests
    {
        
        public void InfixToPostfixTest()
        {
            string input = "9+(3-1)*3+10/2";
            string expect = "9 3 1 - 3 * + 10 2 / + ";
            string result = new StackForAffix().InfixToPostfix(input);
            Assert.AreEqual(expect, result);
        }
    }
}
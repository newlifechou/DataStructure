using Microsoft.VisualStudio.TestTools.UnitTesting;
using XS.DataStructure.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.String.Tests
{
    [TestClass()]
    public class StringTestTests
    {
        [TestMethod()]
        public void IndexViaViolentTest()
        {
            StringTest test = new StringTest();

            string source = "hello world are you ok the brown fox jumps over the lazy dog";
            string pattern1 = "hello";
            string pattern2 = "ok";
            string pattern3 = "fox";
            string pattern4 = "lazy";
            string pattern5 = "dog";
            Assert.AreEqual(0, test.IndexViaViolent(source, pattern1));
            Assert.AreEqual(20, test.IndexViaViolent(source, pattern2));
            Assert.AreEqual(33, test.IndexViaViolent(source, pattern3));
            Assert.AreEqual(52, test.IndexViaViolent(source, pattern4));
            Assert.AreEqual(57, test.IndexViaViolent(source, pattern5));

        }
    }
}
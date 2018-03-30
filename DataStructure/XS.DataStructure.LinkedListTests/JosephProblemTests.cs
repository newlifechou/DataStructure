using Microsoft.VisualStudio.TestTools.UnitTesting;
using XS.DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList.Tests
{
    [TestClass()]
    public class JosephProblemTests
    {
        [TestMethod()]
        public void JosephItTest()
        {
            JosephProblem p = new JosephProblem(9);
            p.JosephIt(3);
            var result = p.ResultList;
            Assert.AreEqual(result[0], 3);
            Assert.AreEqual(result[1], 6);
            Assert.AreEqual(result[2], 9);
            Assert.AreEqual(result[3], 4);
            Assert.AreEqual(result[4], 8);
            Assert.AreEqual(result[5], 5);
            Assert.AreEqual(result[6], 2);
            Assert.AreEqual(result[7], 7);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumNameSpace;

namespace UnitTestSum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicSumTest()
        {
            Sum s = new Sum();
            double a = 5.5;
            double b = 6.6;
            double actualResult = s.sum(a, b);
            double expectedResult = 12.1;
            Assert.AreEqual(expectedResult, actualResult,
                delta: expectedResult / 100);
        }

        [TestMethod]
        public void SumTestNegativeInputx()
        {
            Sum s = new Sum();
            double a = -5.5;
            double b = -6.6;
            double actualResult = s.sum(a, b);
            double expectedResult = -12.1;
            double delta = Math.Abs(expectedResult / 100);
            bool isEqual = Math.Abs(expectedResult - actualResult) < delta;
            Assert.IsTrue(isEqual);
        }
    }
}

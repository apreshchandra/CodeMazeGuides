using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActionAndFuncDelegatesTests;
using System;
using ActionAndFuncDelegates;

namespace ActionAndFuncDelegatesTests
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void WhenFuncCalled_SumIsReturned()
        {
            Func<int, int, int, int> actualFunc = Program.CalculateSomething;
            var result = actualFunc(10, 10, 10);
            Assert.AreEqual(30, result);
        }

    }
}

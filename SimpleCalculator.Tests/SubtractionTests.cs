using System;
using SimpleCalculator.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class SubtractionTests
    {
        [TestMethod]
        public void SubtractCanBeInstantiated()
        {
            Subtract test = new Subtract();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void SubtractOperateGivesExpectedOutputWithValidInput()
        {
            Subtract test = new Subtract();

            Assert.AreEqual("0", test.Operate(2, 2));
            Assert.AreEqual("6", test.Operate(8, 2));
            Assert.AreEqual("195", test.Operate(200, 5));
            Assert.AreEqual("-5", test.Operate(-2, 3));
            Assert.AreEqual("0", test.Operate(0, 0));
        }
    }
}

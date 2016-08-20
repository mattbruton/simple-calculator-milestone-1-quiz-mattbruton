using System;
using SimpleCalculator.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MultiplyTests
    {
        [TestMethod]
        public void MultiplyCanBeInstantiated()
        {
            Multiply test = new Multiply();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void MultiplyOperateGivesExpectedOutputWithValidInput()
        {
            Multiply test = new Multiply();

            Assert.AreEqual("4", test.Operate(2, 2));
            Assert.AreEqual("16", test.Operate(8, 2));
            Assert.AreEqual("1000", test.Operate(200, 5));
            Assert.AreEqual("-6", test.Operate(-2, 3));
            Assert.AreEqual("0", test.Operate(0, 0));
        }
    }
}

using System;
using SimpleCalculator.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void DivideCanBeInstantiated()
        {
            Divide test = new Divide();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void DivideOperateGivesExpectedOutputWithValidInput()
        {
            Divide test = new Divide();

            Assert.AreEqual("1", test.Operate(2, 2));
            Assert.AreEqual("4", test.Operate(8, 2));
            Assert.AreEqual("40", test.Operate(200, 5));
            Assert.AreEqual("3", test.Operate(9, 3));
            Assert.AreEqual("5", test.Operate(100, 20));
        }

        [TestMethod]
        public void DivideReturnsErrorStringWhenDividingByZero()
        {
            Divide test = new Divide();

            Assert.AreEqual("You cannot divide by zero.", test.Operate(2, 0));
        }
    }
}

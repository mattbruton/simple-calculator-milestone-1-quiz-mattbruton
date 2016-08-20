using System;
using SimpleCalculator.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void AddCanBeInstantiated()
        {
            Add test = new Add();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void AddOperateGivesExpectedOutputWithValidInput()
        {
            Add test = new Add();

            Assert.AreEqual("4", test.Operate(2, 2));
            Assert.AreEqual("10", test.Operate(8, 2));
            Assert.AreEqual("205", test.Operate(200, 5));
            Assert.AreEqual("1", test.Operate(-2, 3));
            Assert.AreEqual("0", test.Operate(0, 0));
        }
    }
}

using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantTests
    {
        [TestMethod]
        public void ConstantIsInputANewConstReturnsTrueIfNewConst()
        {
            Assert.AreEqual(true, Constants.IsInputANewConst("n = 2"));
        }

        [TestMethod]
        public void ConstantIsInputANewConstReturnsFalseIfInputDoesNotMatchPattern()
        {
            Assert.AreEqual(false, Constants.IsInputANewConst("n + 2"));
        }
    }
}

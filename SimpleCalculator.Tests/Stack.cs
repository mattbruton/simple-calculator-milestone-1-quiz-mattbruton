using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackCanBeInstantiated()
        {
            Stack test = new Stack();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void StackCanSetLastAnswerProperty()
        {
            Stack test = new Stack();
            test.SetLastAnswer("4");

            Assert.AreEqual("4", test.LastAnswer);
        }

        [TestMethod]
        public void StackCanSetLastExpressionProperty()
        {
            Stack test = new Stack();
            test.SetLastExpression(4, 5, '+');

            Assert.AreEqual("4 + 5", test.LastExpression);
        }
    }
}

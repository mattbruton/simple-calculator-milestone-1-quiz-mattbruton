using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluatorTests
    {
        [TestMethod]
        public void EvaluatorCanBeInstantiated()
        {
            Evaluator test = new Evaluator();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void EvaluatorCanAddNumbers()
        {
            Evaluator test = new Evaluator();
            int expectedSum = 4;
            test.EvaluateUserInput(2, 2, '+');

            Assert.AreEqual(expectedSum, test.ResultFromEval);
        }

        [TestMethod]
        public void EvaluatorCanSubtractNumbers()
        {
            Evaluator test = new Evaluator();
            int expectedDiff = 0;
            test.EvaluateUserInput(2, 2, '-');

            Assert.AreEqual(expectedDiff, test.ResultFromEval);
        }

        [TestMethod]
        public void EvaluatorCanFindModulus()
        {
            Evaluator test = new Evaluator();
            int expectedRemainder = 0;
            test.EvaluateUserInput(2, 2, '%');

            Assert.AreEqual(expectedRemainder, test.ResultFromEval);
        }

        [TestMethod]
        public void EvaluatorCanMultiplyNumbers()
        {
            Evaluator test = new Evaluator();
            int expectedProduct = 4;
            test.EvaluateUserInput(2, 2, '*');

            Assert.AreEqual(expectedProduct, test.ResultFromEval);
        }

        [TestMethod]
        public void EvaluatorCanPerformIntegerDivision()
        {
            Evaluator test = new Evaluator();
            int expectedQuotient = 1;
            test.EvaluateUserInput(2, 2, '/');

            Assert.AreEqual(expectedQuotient, test.ResultFromEval);
        }

        [TestMethod]
        public void EvaluatorCatchesExceptionWhenDividingByZeroButHandlesItByChangingBoolValue()
        {
            Evaluator test = new Evaluator();
            test.EvaluateUserInput(2, 0, '/');

            Assert.AreEqual(true, test.CannotEvaluate);
        }


        // This shouldn't be a concern based on how the variables are passed into the method, but assuming the user supplied a non-operator character as their operator.
        [TestMethod]
        public void EvaluatorChangesBoolWhenItCannotEvaluateAnExpression()
        {
            Evaluator test = new Evaluator();
            test.EvaluateUserInput(2, 0, 'b');

            Assert.AreEqual(true, test.CannotEvaluate);
        }
    }
}

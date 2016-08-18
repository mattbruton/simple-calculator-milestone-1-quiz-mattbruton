using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void ExpressionCanBeInstantiated()
        {
            Expression test = new Expression();
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void AssertCanCaptureTermsOfValidInput()
        {
            Expression test = new Expression();
            test.CheckInputForPattern("2+2");

            Assert.AreEqual(2, test.Value_1);
            Assert.AreEqual(2, test.Value_2);
            Assert.AreEqual('+', test.Operator);
        }

        [TestMethod]
        public void AssertCanCaptureWithExtraSpacingBeforeOperator()
        {
            Expression test = new Expression();
            test.CheckInputForPattern("   2+2");

            Assert.AreEqual(2, test.Value_1);
            Assert.AreEqual(2, test.Value_2);
            Assert.AreEqual('+', test.Operator);
        }

        [TestMethod]
        public void AssertCanCaptureWithExtraSpacingAfterOperator()
        {
            Expression test = new Expression();
            test.CheckInputForPattern("2+      2");

            Assert.AreEqual(2, test.Value_1);
            Assert.AreEqual(2, test.Value_2);
            Assert.AreEqual('+', test.Operator);
        }

        [TestMethod]
        public void AssertCanCaptureWithExtraSpacingOnBothSidesOfOperator()
        {
            Expression test = new Expression();
            test.CheckInputForPattern("2       -      2");

            Assert.AreEqual(2, test.Value_1);
            Assert.AreEqual(2, test.Value_2);
            Assert.AreEqual('-', test.Operator);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatExeptionThrownOnInvalidValue()
        {
            Expression test = new Expression();
            test.CheckInputForPattern("2+bad");

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatExeptionThrownOnInvalidOperatorChar()
        {
            Expression test = new Expression();
            test.CheckInputForPattern("2^2");

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatExeptionThrownOnMissingTerm()
        {
            Expression test = new Expression();
            test.CheckInputForPattern("+2");

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatExeptionThrownOnMissingOperatorTerm()
        {
            Expression test = new Expression();
            test.CheckInputForPattern("12");

            Assert.Fail();
        }
    }
}
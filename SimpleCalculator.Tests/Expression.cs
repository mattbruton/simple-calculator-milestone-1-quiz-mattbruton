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
            test.CheckInputForStandardPattern("2+2");

            Assert.AreEqual(2, test.Value_1);
            Assert.AreEqual(2, test.Value_2);
            Assert.AreEqual('+', test.Operator);
        }

        [TestMethod]
        public void AssertCanCaptureWithExtraSpacingBeforeOperator()
        {
            Expression test = new Expression();
            test.CheckInputForStandardPattern("   2+2");

            Assert.AreEqual(2, test.Value_1);
            Assert.AreEqual(2, test.Value_2);
            Assert.AreEqual('+', test.Operator);
        }

        [TestMethod]
        public void AssertCanCaptureWithExtraSpacingAfterOperator()
        {
            Expression test = new Expression();
            test.CheckInputForStandardPattern("2+      2");

            Assert.AreEqual(2, test.Value_1);
            Assert.AreEqual(2, test.Value_2);
            Assert.AreEqual('+', test.Operator);
        }

        [TestMethod]
        public void AssertCanCaptureWithExtraSpacingOnBothSidesOfOperator()
        {
            Expression test = new Expression();
            test.CheckInputForStandardPattern("2       -      2");

            Assert.AreEqual(2, test.Value_1);
            Assert.AreEqual(2, test.Value_2);
            Assert.AreEqual('-', test.Operator);
        }

        [TestMethod]
        public void ReturnFalseWhenInvalidValue()
        {
            Expression test = new Expression();

            Assert.IsFalse(test.CheckInputForStandardPattern("2+bad"));
        }

        [TestMethod]
        public void ReturnFalseWhenInvalidOperatorChar()
        {
            Expression test = new Expression();

            Assert.IsFalse(test.CheckInputForStandardPattern("2^2"));
        }

        [TestMethod]
        public void ReturnFalseWhenMissingTerm()
        {
            Expression test = new Expression();

            Assert.IsFalse(test.CheckInputForStandardPattern("+2"));
        }

        [TestMethod]
        public void ReturnFalseWhenMissingOperatorTerm()
        {
            Expression test = new Expression();

            Assert.IsFalse(test.CheckInputForStandardPattern("12"));
        }
    }
}
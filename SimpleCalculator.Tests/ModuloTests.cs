using SimpleCalculator.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ModuloTests
    {
        [TestMethod]
        public void ModulusCanBeInstantiated()
        {
            Modulus test = new Modulus();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void ModulusOperateGivesExpectedOutputWithValidInput()
        {
            Modulus test = new Modulus();

            Assert.AreEqual("0", test.Operate(2, 2));
            Assert.AreEqual("0", test.Operate(8, 2));
            Assert.AreEqual("1", test.Operate(201, 5));
            Assert.AreEqual("0", test.Operate(9, 3));
            Assert.AreEqual("0", test.Operate(100, 20));
            Assert.AreEqual("3", test.Operate(7, 4));
        }
    }
}

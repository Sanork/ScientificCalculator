using ScientificCalculator;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorClass_Exists()
        {
            var calc = new ScientificCalculator.Calculator();
        }

        [TestMethod]
        public void CalcAdd2And2Test()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(4, calculator.Add(2, 2));
        }

        [TestMethod]
        public void CalcAdd1And3Test()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(4, calculator.Add(1, 3));
        }

        [TestMethod]
        public void CalcSubtract5And3Test()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.Subtract(5, 3));
        }

        [TestMethod]
        public void CalcMultiply3And4Test()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(12, calculator.Multiply(3, 4));
        }
    }
}
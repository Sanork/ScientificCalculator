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
    }
}
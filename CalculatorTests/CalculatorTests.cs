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

        [TestMethod]
        public void CalcDivide6And2Test()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(3, calculator.Divide(6, 2));
        }

        [TestMethod]
        public void CalcSolveEquation_XPlus2Equals5_Returns3()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(3, calculator.SolveEquation("x + 2 = 5"));
        }

        [TestMethod]
        public void CalcSolveEquation_3xMinus6Equals9_Returns5()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(5, calculator.SolveEquation("3 * x - 6 = 9"));
        }

        [TestMethod]
        public void CalcIntegrate_XFrom0To2_Returns2()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.Integrate("x", 0, 2));
        }

        [TestMethod]
        public void CalcIntegrate_XSquaredFrom0To3_Returns9()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(9, calculator.Integrate("x^2", 0, 3));
        }
    }
}
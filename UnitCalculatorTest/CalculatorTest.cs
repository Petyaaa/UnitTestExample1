using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestExample1;

namespace UnitCalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        //sum
        [TestMethod]
        public void TestCalculatorSum()
        {

           Calculator calculator = new Calculator();
              double result = calculator.Sum(2, 3);
                Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestCalculatorSum2()
        {
            Calculator c = new Calculator();
            double result = c.Sum(-2, 3);
            Assert.AreEqual(1, result);
        }

        //subtract
        [TestMethod]
        public void TestCalculatorSubtract()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestCalculatorSubtract2()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Subtract(3, 5);
            Assert.AreEqual(-2, result);
        }

        //multiply
        [TestMethod]
        public void TestCalculatorMultiply()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void TestCalculatorMultiply2()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Multiply(-5, 3);
            Assert.AreEqual(-15, result);
        }

        //divide
        [TestMethod]
        public void TestCalculatorDivide()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
            
        }
        [TestMethod]
        public void TestCalculatorDivide2()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(3, 6);
            Assert.AreEqual(0.5, result);
        }   
    }
}
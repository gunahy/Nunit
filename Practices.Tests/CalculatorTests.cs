using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace Practices.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup() { _calculator = new Calculator(); }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Assert.That(_calculator.Subtraction(300, 10) == 290);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Assert.That(_calculator.Division(10, 5) == 2);
        }
        [Test]
        public void Division_MustThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Division(30, 0));
        }
        [Test]
        public void Additional_ValidInputs_ReturnsCorrectSum()
        {
            Assert.That(_calculator.Additional(2, 4) == 6);
        }
        [Test]
        public void Multiplication_ValidInputs_ReturnsCorrectProduct()
        {
            Assert.That(_calculator.Miltiplication(2, 4) == 8);
        }
    }  
}

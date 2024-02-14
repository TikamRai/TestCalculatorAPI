namespace Calculator.Tests;
using CalculatorLibrary;

public class Tests
{
    private CalculatorService calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorService();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum_WhenBothOperandsArePositive()
        {
            decimal num1 = 2;
            decimal num2 = 3;

            decimal result = calculator.Add(num1, num2);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_ShouldReturnCorrectSum_WhenOneOperandIsZero()
        {
            decimal num1 = 2;
            decimal num2 = 0;

            decimal result = calculator.Add(num1, num2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Add_ShouldReturnNegativeSum_WhenBiggerValuedOperandIsNegative()
        {
            decimal num1 = 2;
            decimal num2 = -3;

            decimal result = calculator.Add(num1, num2);

            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Add_ShouldReturnNegativeSum_WhenBothOperandsAreNegative()
        {
            decimal num1 = -2;
            decimal num2 = -3;

            decimal result = calculator.Add(num1, num2);

            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Add_ShouldReturnCorrectSum_WhenBothOperandsAreDecimalNumbers()
        {
            decimal num1 = 2.5m;
            decimal num2 = 3.5m;

            decimal result = calculator.Add(num1, num2);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference_WhenFristOperandIsGreaterThanSecondOperand()
        {
            decimal num1 = 5;
            decimal num2 = 3;

            decimal result = calculator.Subtract(num1, num2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Subtract_ShouldReturnNegativeDifference_WhenFristOperandIsSmallerThanSecondOperand()
        {
            decimal num1 = 3;
            decimal num2 = 5;

            decimal result = calculator.Subtract(num1, num2);

            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Subtract_ShouldReturnNegativeDifference_WhenFristOperandIsANegativeNumber()
        {
            decimal num1 = -5;
            decimal num2 = 3;

            decimal result = calculator.Subtract(num1, num2);

            Assert.That(result, Is.EqualTo(-8));
        }

        [Test]
        public void Subtract_ShouldReturnPositibveDifference_WhenSecondOperandIsANegativeNumber()
        {
            decimal num1 = 5;
            decimal num2 = -3;

            decimal result = calculator.Subtract(num1, num2);

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference_WhenBothOperandsAreDecimalNumbers()
        {
            decimal num1 = 5.5m;
            decimal num2 = 3.5m;

            decimal result = calculator.Subtract(num1, num2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct_WhenBothOperandsArePositive()
        {
            decimal num1 = 2;
            decimal num2 = 3;

            decimal result = calculator.Multiply(num1, num2);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_ShouldReturnNegativeProduct_WhenOneOperandIsNegative()
        {
            decimal num1 = -2;
            decimal num2 = 3;

            decimal result = calculator.Multiply(num1, num2);

            Assert.That(result, Is.EqualTo(-6));
        }

        [Test]
        public void Multiply_ShouldReturnPositiveProduct_WhenBothOperandsAreNegative()
        {
            decimal num1 = -2;
            decimal num2 = -3;

            decimal result = calculator.Multiply(num1, num2);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_ShouldReturnZero_WhenOneOperandIsZero()
        {
            decimal num1 = 2;
            decimal num2 = 0;

            decimal result = calculator.Multiply(num1, num2);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct_WhenOneOperandIsADecimalNumber()
        {
            decimal num1 = 2.5m;
            decimal num2 = 3;

            decimal result = calculator.Multiply(num1, num2);

            Assert.That(result, Is.EqualTo(7.5));
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient_WhenTheDividendIsGreaterThanTheDivisor()
        {
            decimal num1 = 10;
            decimal num2 = 2;

            decimal result = calculator.Divide(num1, num2);

            Assert.That(result, Is.EqualTo(5));
        }


        [Test]
        public void Divide_ShouldReturnNegativeQuotient_WhenDividendIsANegativeNumber()
        {
            decimal num1 = -10;
            decimal num2 = 2;

            decimal result = calculator.Divide(num1, num2);

            Assert.That(result, Is.EqualTo(-5));
        }



        [Test]
        public void Divide_ShouldReturnCorrectQuotient_WhenBothTheDividendAndTheDivisorAreDecimalNumbers()
        {
            decimal num1 = 10.5m;
            decimal num2 = 2.5m;

            decimal result = calculator.Divide(num1, num2);

            Assert.That(result, Is.EqualTo(4.2));
        }

        [Test]
        public void Divide_ShouldReturnZer_WhenBothTheDividendIsZero()
        {
            decimal num1 = 0;
            decimal num2 = 2;

            decimal result = calculator.Divide(num1, num2);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Divide_ShouldThrowException_WhenDivisorIsZero()
        {
            decimal num1 = 10;
            decimal num2 = 0;

            Assert.Throws<System.DivideByZeroException>(() => calculator.Divide(num1, num2));
        }

        [Test]
        public void Modulo_ShouldReturnCorrectRemainder_WhenBothOperandsArePotitiveNumbers()
        {
            decimal num1 = 10;
            decimal num2 = 3;

            decimal result = calculator.Modulo(num1, num2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Modulo_ShouldReturnZero_WhenDividendIsZero()
        {
            decimal num1 = 0;
            decimal num2 = 5;

            decimal result = calculator.Modulo(num1, num2);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Modulo_ShouldReturnZero_WhenBothOperandsAreSameNegativeNumbers()
        {
            decimal num1 = -5;
            decimal num2 = -5;

            decimal result = calculator.Modulo(num1, num2);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Modulo_ShouldReturnPositiveRemainder_WhenTheDividendIsPositiveAndTheDivisorIsNegative()
        {
            decimal num1 = 10;
            decimal num2 = -3;

            decimal result = calculator.Modulo(num1, num2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Modulo_ShouldThrowException_WhenTheDivisorIsZero()
        {
            decimal num1 = 10;
            decimal num2 = 0;

            Assert.Throws<System.DivideByZeroException>(() => calculator.Modulo(num1, num2));
        }
}
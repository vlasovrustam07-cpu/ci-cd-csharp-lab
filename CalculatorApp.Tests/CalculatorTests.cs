using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }

        // Задача #2: тест метода Add на наборе значений
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-2, -3, -5)]
        [InlineData(-5, 5, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1000000, 2000000, 3000000)]
        public void Add_ReturnsCorrectSum_ForDifferentValues(int a, int b, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(a, b);
            Assert.Equal(expected, result);
        }

        // Задача #3: тест метода Subtract
        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(3, 5, -2)]
        [InlineData(-4, -6, 2)]
        [InlineData(0, 7, -7)]
        [InlineData(10, 0, 10)]
        public void Subtract_ReturnsCorrectDifference(int a, int b, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        // Задача #4: тест метода Multiply
        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(-3, 6, -18)]
        [InlineData(-4, -5, 20)]
        [InlineData(0, 99, 0)]
        [InlineData(1, -7, -7)]
        public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Multiply(a, b);
            Assert.Equal(expected, result);
        }
    }
}

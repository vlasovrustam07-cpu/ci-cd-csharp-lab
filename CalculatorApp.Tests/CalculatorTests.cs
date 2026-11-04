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
    }
}

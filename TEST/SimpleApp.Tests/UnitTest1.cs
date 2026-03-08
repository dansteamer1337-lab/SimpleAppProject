using Xunit;
using SimpleApp;

namespace SimpleApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void AddNumbers_ShouldReturnCorrectSum()
        {
            int result = Program.AddNumbers(5, 7);
            Assert.Equal(12, result);
        }

        [Fact]
        public void AddNumbers_ShouldHandleNegativeNumbers()
        {
            int result = Program.AddNumbers(-3, 7);
            Assert.Equal(4, result);
        }

        // Новые тесты
        [Fact]
        public void AddNumbers_ShouldHandleZero()
        {
            int result = Program.AddNumbers(0, 10);
            Assert.Equal(10, result);
        }

        [Fact]
        public void AddNumbers_ShouldHandleBothNegative()
        {
            int result = Program.AddNumbers(-5, -3);
            Assert.Equal(-8, result);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(-1, -1, -2)]
        [InlineData(100, 200, 300)]
        [InlineData(-50, 25, -25)]
        public void AddNumbers_ShouldReturnCorrectSum_ForVariousInputs(int a, int b, int expected)
        {
            int result = Program.AddNumbers(a, b);
            Assert.Equal(expected, result);
        }
    }
}
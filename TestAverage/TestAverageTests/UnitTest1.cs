using System;
using Xunit;
using TestAverage;

namespace TestAverageTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1000, 10, 100)]
        [InlineData(700, 6, 117)]
        [InlineData(789, 5, 158)]
        [InlineData(200, 6, 33)]
        [InlineData(250, 5, 50)]
        public void TestGetAverage(int sum, int totalTests, int expected)
        {
            //Arrange
            var averageInstance = new Average();

            //act
            var actual = averageInstance.GetAverage(sum, totalTests);

            //assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(100, 100)]
        [InlineData(50, 50)]
        [InlineData(25, 25)]
        [InlineData(1, 1)]
        public void TestTotal(int input, int expected)
        {
            var totalInstance = new Average();

            var actual = totalInstance.GetTotalTests(input);

            Assert.Equal(actual, expected);

        }
    }
}

using FluentAssertions;
using Lib;

namespace Tests;

public class CalculatorTests
{
    [Theory]
    [ClassData(typeof(IntegerCalculatorTestCases))]
    public void Should_Get_Sum_Of_Numbers(int[]? numbers, int expectedSum)
    {
        // arrange
        var calculator = new Calculator<int>();

        // act
        var sum = calculator.Sum(numbers);

        // assert
        sum.Should().Be(expectedSum);
    }
    
    private class IntegerCalculatorTestCases : TheoryData<int[]?, int>
    {
        public IntegerCalculatorTestCases()
        {
            Add(null, 0);
            Add(Array.Empty<int>(), 0);
            Add(new[] { 1 }, 1);
            Add(new[] { 1, 4 }, 5);
            Add(new[] { 1, 4, -1 }, 4);
        }
    }
}
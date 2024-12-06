using Common.Utils;
using FluentAssertions;

namespace Common.Tests.Unit.Utils
{
    public class FibonacciTests
    {
        [Fact]
        public void GetFirst_Should_Return_List()
        {
            var expected = new List<long> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            var result = Fibonacci.GetFirst(10);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void GetLowerThan_Should_Return_List()
        {
            var expected = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            var result = Fibonacci.GetLowerThan(50);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
using Common.Extensions;
using FluentAssertions;

namespace Common.Tests.Unit.Extensions
{
    public class IntExtensionsTests
    {
        [Fact]
        public void ShouldReturnCirculars()
        {
            var n = 197;

            var expected = new List<int> { 197, 971, 719 };

            n.GetCirculars().Should().BeEquivalentTo(expected);
        }
    }
}

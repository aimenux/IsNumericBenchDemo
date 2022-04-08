using App;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class LargeNumericBenchTests
    {
        [Theory]
        [InlineData("913896812479936712554", true)]
        [InlineData("913896812479936712504321126", true)]
        [InlineData("A913896812479936712554Z", false)]
        [InlineData("A913896812479936712504321126Z", false)]
        public void ShouldBeValidForLargeNumericUsingLinq(string number, bool expected)
        {
            // arrange
            var bench = new LargeNumericBench
            {
                Number = number
            };

            // act
            var ok = bench.UsingLinq();

            // assert
            ok.Should().Be(expected);
        }

        [Theory]
        [InlineData("913896812479936712554", true)]
        [InlineData("913896812479936712504321126", true)]
        [InlineData("A913896812479936712554Z", false)]
        [InlineData("A913896812479936712504321126Z", false)]
        public void ShouldBeValidForLargeNumericUsingInlineRegex(string number, bool expected)
        {
            // arrange
            var bench = new LargeNumericBench
            {
                Number = number
            };

            // act
            var ok = bench.UsingInlineRegex();

            // assert
            ok.Should().Be(expected);
        }

        [Theory]
        [InlineData("913896812479936712554", true)]
        [InlineData("913896812479936712504321126", true)]
        [InlineData("A913896812479936712554Z", false)]
        [InlineData("A913896812479936712504321126Z", false)]
        public void ShouldBeValidForLargeNumericUsingCompiledRegex(string number, bool expected)
        {
            // arrange
            var bench = new LargeNumericBench
            {
                Number = number
            };

            // act
            var ok = bench.UsingCompiledRegex();

            // assert
            ok.Should().Be(expected);
        }

        [Theory]
        [InlineData("913896812479936712554", true)]
        [InlineData("913896812479936712504321126", true)]
        [InlineData("A913896812479936712554Z", false)]
        [InlineData("A913896812479936712504321126Z", false)]
        public void ShouldBeValidForLargeNumericUsingBigInteger(string number, bool expected)
        {
            // arrange
            var bench = new LargeNumericBench
            {
                Number = number
            };

            // act
            var ok = bench.UsingBigInteger();

            // assert
            ok.Should().Be(expected);
        }
    }
}
using App;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class SmallNumericBenchTests
    {
        [Theory]
        [InlineData("91389548121241", true)]
        [InlineData("9138968124799367125", true)]
        [InlineData("A91389548121241Z", false)]
        [InlineData("A9138968124799367125Z", false)]
        public void ShouldBeValidForLargeNumericUsingLinq(string number, bool expected)
        {
            // arrange
            var bench = new SmallNumericBench
            {
                Number = number
            };

            // act
            var ok = bench.UsingLinq();

            // assert
            ok.Should().Be(expected);
        }

        [Theory]
        [InlineData("91389548121241", true)]
        [InlineData("9138968124799367125", true)]
        [InlineData("A91389548121241Z", false)]
        [InlineData("A9138968124799367125Z", false)]
        public void ShouldBeValidForLargeNumericUsingInlineRegex(string number, bool expected)
        {
            // arrange
            var bench = new SmallNumericBench
            {
                Number = number
            };

            // act
            var ok = bench.UsingInlineRegex();

            // assert
            ok.Should().Be(expected);
        }

        [Theory]
        [InlineData("91389548121241", true)]
        [InlineData("9138968124799367125", true)]
        [InlineData("A91389548121241Z", false)]
        [InlineData("A9138968124799367125Z", false)]
        public void ShouldBeValidForLargeNumericUsingCompiledRegex(string number, bool expected)
        {
            // arrange
            var bench = new SmallNumericBench
            {
                Number = number
            };

            // act
            var ok = bench.UsingCompiledRegex();

            // assert
            ok.Should().Be(expected);
        }

        [Theory]
        [InlineData("91389548121241", true)]
        [InlineData("9138968124799367125", true)]
        [InlineData("A91389548121241Z", false)]
        [InlineData("A9138968124799367125Z", false)]
        public void ShouldBeValidForLargeNumericUsingBigInteger(string number, bool expected)
        {
            // arrange
            var bench = new SmallNumericBench
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
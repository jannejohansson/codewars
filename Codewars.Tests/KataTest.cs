using System;
using Xunit;
using Codewars;

namespace Codewars.Tests
{
    public class KataTest
    {
        [Theory]
        [InlineData(9119, 811181)]
        [InlineData(3125, 91425)]
        [InlineData(87102, 6449104)]
        public void SquareEveryDigit(int digits, int expected)
        {
            var actual = Kata.SquareEveryDigit(digits);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 2)]
        [InlineData(36, 3)]
        [InlineData(37, -1)]
        [InlineData(100, 4)]
        [InlineData(225, 5)]
        [InlineData(1071225, 45)]
        [InlineData(91716553919377, -1)]
        public void BuildAPileOfCubes(long m, long expected)
        {
            var actual = Kata.BuildAPileOfCubes(m);

            Assert.Equal(expected, actual);
        }


    }
}

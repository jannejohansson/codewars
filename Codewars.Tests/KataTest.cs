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
    }
}

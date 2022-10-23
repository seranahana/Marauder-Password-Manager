using SimplePM.Library.Factories;
using System;
using Xunit;

namespace SimplePM.Library.Tests
{
    public class PasswordGeneratorUnitTests
    {
        [Theory]
        [InlineData(10)]
        [InlineData(23)]
        [InlineData(44)]
        [InlineData(76)]
        [InlineData(127)]
        public void TestGeneratedPasswordReliability(int length)
        {
            IPasswordGenerator generator = PasswordGeneratorFactory.Create();

            bool actual = generator.Generate(length).IsReliablePassword();
            Assert.True(actual);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(23)]
        [InlineData(44)]
        [InlineData(76)]
        [InlineData(127)]
        public void TestRequiredGeneratedPasswordLength(int length)
        {
            IPasswordGenerator generator = PasswordGeneratorFactory.Create();

            int expected = length;

            int actual = generator.Generate(length).Length;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        [InlineData(0)]
        public void TestEdgePasswordLength(int length)
        {
            IPasswordGenerator generator = PasswordGeneratorFactory.Create();

            Assert.Throws<ArgumentOutOfRangeException>(() => generator.Generate(length));
        }
    }
}

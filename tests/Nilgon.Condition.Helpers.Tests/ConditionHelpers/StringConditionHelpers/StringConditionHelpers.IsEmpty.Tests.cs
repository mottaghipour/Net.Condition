using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
    public sealed class StringConditionHelpers_IsEmpty_Tests
    {
        [Fact]
        public void IsEmpty_ReturnsTrue_WhenStringIsEmpty()
        {
            var input = string.Empty;

            var result = input.IsEmpty();

            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_ReturnsFalse_WhenStringIsNotEmpty()
        {
            var input = "test";

            var result = input.IsEmpty();

            Assert.False(result);
        }

        [Fact]
        public void IsEmpty_ReturnsFalse_WhenStringIsNull()
        {
            var input = null as string;

            var result = input.IsEmpty();

            Assert.False(result);
        }
    }
}

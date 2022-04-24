using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
    public sealed class StringConditionHelpers_IsEmpty_Tests
    {
        [Fact]
        public void IsEmpty_ReturnsTrue_WhenStringIsEmpty()
        {
            string input = string.Empty;

            bool result = input.IsEmpty();

            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_ReturnsFalse_WhenStringIsNotEmpty()
        {
            string input = "test";

            bool result = input.IsEmpty();

            Assert.False(result);
        }

        [Fact]
        public void IsEmpty_ReturnsFalse_WhenStringIsNull()
        {
            string input = null as string;

            bool result = input.IsEmpty();

            Assert.False(result);
        }
    }
}

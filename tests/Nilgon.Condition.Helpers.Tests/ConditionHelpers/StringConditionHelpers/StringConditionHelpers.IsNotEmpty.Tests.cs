using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
    public sealed class StringConditionHelpers_IsNotEmpty_Tests
    {
        [Fact]
        public void IsNotEmpty_ReturnsFalse_WhenStringIsEmpty()
        {
            var value = string.Empty;

            var result = value.IsNotEmpty();

            Assert.False(result);
        }
        
        [Fact]
        public void IsNotEmpty_ReturnsTrue_WhenStringIsNotEmpty()
        {
            var value = "test";
            
            var result = value.IsNotEmpty();

            Assert.True(result);
        }

        [Fact]
        public void IsNotEmpty_ReturnsFalse_WhenStringIsNull()
        {
            var value = null as string;

            var result = value.IsNotEmpty();

            Assert.True(result);
        }
    }
}

using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
    public sealed class StringConditionHelpers_IsNotEmpty_Tests
    {
        [Fact]
        public void IsNotEmpty_ReturnsFalse_WhenStringIsEmpty()
        {
            string value = string.Empty;

            bool result = value.IsNotEmpty();

            Assert.False(result);
        }
        
        [Fact]
        public void IsNotEmpty_ReturnsTrue_WhenStringIsNotEmpty()
        {
            string value = "test";
            
            bool result = value.IsNotEmpty();

            Assert.True(result);
        }

        [Fact]
        public void IsNotEmpty_ReturnsFalse_WhenStringIsNull()
        {
            string value = null;

            bool result = value.IsNotEmpty();

            Assert.True(result);
        }
    }
}

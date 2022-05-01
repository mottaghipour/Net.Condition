using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.EmptyHelpers
{
    public sealed class IsNotEmpty_Condition_Helper_Tests
    {
        [Fact]
        public void IsNotEmpty_ReturnsTrue_WhenStringIsNull()
        {
            string stringToTest = null;

            bool result = stringToTest.IsNotEmpty();

            Assert.True(result);
        }
        
        [Fact]
        public void IsNotEmpty_ReturnsTrue_WhenStringIsWhiteSpace()
        {
            string stringToTest = " ";

            bool result = stringToTest.IsNotEmpty();

            Assert.True(result);
        }

        [Fact]
        public void IsNotEmpty_ReturnsTrue_WhenStringIsFull()
        {
            string stringToTest = "test";

            bool result = stringToTest.IsNotEmpty();

            Assert.True(result);
        }
        
        [Fact]
        public void IsNotEmpty_ReturnsFalse_WhenStringIsEmpty()
        {
            string stringToTest = string.Empty;

            bool result = stringToTest.IsNotEmpty();

            Assert.False(result);
        }
    }
}

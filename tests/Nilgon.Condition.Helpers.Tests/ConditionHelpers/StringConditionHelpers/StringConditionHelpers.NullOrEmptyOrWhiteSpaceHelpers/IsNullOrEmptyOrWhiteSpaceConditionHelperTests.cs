using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.NullOrEmptyOrWhiteSpaceHelpers
{
    public sealed class IsNullOrEmptyOrWhiteSpace_Condition_Helper_Tests
    {
        [Fact]
        public void IsNullOrEmptyOrWhiteSpace_ReturnsTrue_WhenStringIsNull()
        {
            string stringToTest = null;

            bool result = stringToTest.IsNullOrEmptyOrWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmptyOrWhiteSpace_ReturnsTrue_WhenStringIsEmpty()
        {
            string stringToTest = string.Empty;

            bool result = stringToTest.IsNullOrEmptyOrWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmptyOrWhiteSpace_ReturnsTrue_WhenStringIsWhiteSpace()
        {
            string stringToTest = " ";

            bool result = stringToTest.IsNullOrEmptyOrWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmptyOrWhiteSpace_ReturnsFalse_WhenStringIsFull()
        {
            string stringToTest = "test";

            bool result = stringToTest.IsNullOrEmptyOrWhiteSpace();

            Assert.False(result);
        }
    }
}

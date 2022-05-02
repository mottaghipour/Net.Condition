using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.NullOrWhiteSpaceHelpers
{
    public sealed class IsNullOrWhiteSpace_Condition_Helper_Tests
    {
        [Fact]
        public void IsNullOrWhiteSpace_ReturnsTrue_WhenStringIsNull()
        {
            string stringToTest = null;

            bool result = stringToTest.IsNullOrWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhiteSpace_ReturnsTrue_WhenStringIsWhiteSpace()
        {
            string stringToTest = " ";

            bool result = stringToTest.IsNullOrWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhiteSpace_ReturnsFalse_WhenStringIsEmpty()
        {
            string stringToTest = string.Empty;

            bool result = stringToTest.IsNullOrWhiteSpace();

            Assert.False(result);
        }

        [Fact]
        public void IsNullOrWhiteSpace_ReturnsFalse_WhenStringIsFull()
        {
            string stringToTest = "test";

            bool result = stringToTest.IsNullOrWhiteSpace();

            Assert.False(result);
        }
    }
}

using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
    public sealed class StringConditionHelpers_IsWhiteSpace_Tests
    {
        [Fact]
        public void IsWhiteSpace_ReturnsTrue_WhenStringIsWhiteSpace()
        {
            string stringToTest = " ";

            bool result = stringToTest.IsWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsWhiteSpace_ReturnsFalse_WhenStringIsEmpty()
        {
            string stringToTest = "";

            bool result = stringToTest.IsWhiteSpace();

            Assert.False(result);
        }


        [Fact]
        public void IsWhiteSpace_ReturnsFalse_WhenStringIsFull()
        {
            string stringToTest = "test";

            bool result = stringToTest.IsWhiteSpace();

            Assert.False(result);
        }

        [Fact]
        public void IsWhiteSpace_ReturnsFalse_WhenStringIsNull()
        {
            string stringToTest = null;

            bool result = stringToTest.IsWhiteSpace();

            Assert.False(result);
        }
    }
}

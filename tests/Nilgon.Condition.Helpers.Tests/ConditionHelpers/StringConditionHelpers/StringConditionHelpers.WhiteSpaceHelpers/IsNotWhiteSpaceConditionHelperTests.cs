using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.WhiteSpaceHelpers
{
    public sealed class IsNotWhiteSpace_Condition_Helper_Tests
    {
        [Fact]
        public void IsNotWhiteSpace_ReturnsTrue_WhenStringIsNull()
        {
            string stringToTest = null;

            bool result = stringToTest.IsNotWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNotWhiteSpace_ReturnsTrue_WhenStringIsEmpty()
        {
            string stringToTest = string.Empty;

            bool result = stringToTest.IsNotWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNotWhiteSpace_ReturnsTrue_WhenStringIsFull()
        {
            string stringToTest = "test";

            bool result = stringToTest.IsNotWhiteSpace();

            Assert.True(result);
        }
        
        [Fact]
        public void IsNotWhiteSpace_ReturnsFalse_WhenStringIsWhiteSpace()
        {
            string stringToTest = " ";

            bool result = stringToTest.IsNotWhiteSpace();

            Assert.False(result);
        }
    }
}

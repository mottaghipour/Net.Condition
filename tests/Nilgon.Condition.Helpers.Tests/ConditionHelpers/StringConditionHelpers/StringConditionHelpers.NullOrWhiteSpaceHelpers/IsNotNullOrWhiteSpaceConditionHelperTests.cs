using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.NotNullOrWhiteSpaceHelpers
{
    public sealed class IsNotNullOrWhiteSpace_Condition_Helper_Tests
    {
        [Fact]
        public void IsNotNullOrWhiteSpace_ReturnsTrue_WhenStringIsEmpty()
        {
            string stringToTest = string.Empty;

            bool result = stringToTest.IsNotNullOrWhiteSpace();

            Assert.True(result);
        }
        
        [Fact]
        public void IsNotNullOrWhiteSpace_ReturnsTrue_WhenStringIsFull()
        {
            string stringToTest = "Test";

            bool result = stringToTest.IsNotNullOrWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_ReturnsFalse_WhenStringIsNull()
        {
            string stringToTest = null;

            bool result = stringToTest.IsNotNullOrWhiteSpace();

            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_ReturnsFalse_WhenStringIsWhiteSpace()
        {
            string stringToTest = " ";

            bool result = stringToTest.IsNotNullOrWhiteSpace();

            Assert.False(result);
        }
    }
}

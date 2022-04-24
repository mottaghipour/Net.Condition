using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
    public sealed class StringConditionHelpers_IsNotWhiteSpace_Tests
    {
        [Fact]
        public void IsNotWhiteSpace_ReturnsFalse_WhenStringIsWhiteSpace()
        {
            string stringToTest = " ";

            bool result = stringToTest.IsNotWhiteSpace();

            Assert.False(result);
        }
        
        [Fact]
        public void IsNotWhiteSpace_ReturnsTrue_WhenStringIsFull()
        {
            string stringToTest = "test";

            bool result = stringToTest.IsNotWhiteSpace();

            Assert.True(result);
        }

        [Fact]
        public void IsNotWhiteSpace_ReturnsTrue_WhenStringIsNull()
        {
            string stringToTest = null;

            bool result = stringToTest.IsNotWhiteSpace();

            Assert.True(result);
        }
    }
}

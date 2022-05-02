using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers.NullHelpers
{
    public sealed class IsNull_Condition_Helper_Tests
    {
        [Fact]
        public void IsNull_ReturnsTrue_WhenValueIsNull()
        {
            object objectToTest = null;

            bool result = objectToTest.IsNull();

            Assert.True(result);
        }
        
        [Fact]
        public void IsNull_ReturnsFalse_WhenValueIsNotNull()
        {
            object objectToTest = "test";

            bool result = objectToTest.IsNull();

            Assert.False(result);
        }
    }
}

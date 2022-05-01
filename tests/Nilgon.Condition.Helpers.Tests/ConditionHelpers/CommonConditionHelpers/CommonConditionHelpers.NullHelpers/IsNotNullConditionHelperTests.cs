using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers.NullHelpers
{
    public sealed class IsNotNull_Condition_Helper_Tests
    {
        [Fact]
        public void IsNotNull_ReturnsTrue_WhenValueIsNotNull()
        {
            object value = "test";

            bool result = value.IsNotNull();

            Assert.True(result);
        }
        
        [Fact]
        public void IsNotNull_ReturnsFalse_WhenValueIsNull()
        {
            object value = null;

            bool result = value.IsNotNull();

            Assert.False(result);
        }
    }
}

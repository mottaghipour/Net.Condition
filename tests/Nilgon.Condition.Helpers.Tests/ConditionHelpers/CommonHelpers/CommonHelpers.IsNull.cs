using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers
{
    public sealed class CommonConditionHelpers_IsNull_Tests
    {
        [Fact]
        public void IsNull_ReturnsTrue_WhenValueIsNull()
        {
            object value = null;

            bool result = value.IsNull();

            Assert.True(result);
        }
        
        [Fact]
        public void IsNull_ReturnsFalse_WhenValueIsNotNull()
        {
            object value = "test";

            bool result = value.IsNull();

            Assert.False(result);
        }
    }
}

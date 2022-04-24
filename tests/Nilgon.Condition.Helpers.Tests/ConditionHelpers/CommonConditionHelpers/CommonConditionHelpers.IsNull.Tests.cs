using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers
{
    public sealed class CommonConditionHelpers_IsNull_Tests
    {
        [Fact]
        public void IsNull_ReturnsTrue_WhenValueIsNull()
        {
            var value = null as string;

            var result = value.IsNull();

            Assert.True(result);
        }
        
        [Fact]
        public void IsNull_ReturnsFalse_WhenValueIsNotNull()
        {
            var value = "test";

            var result = value.IsNull();

            Assert.False(result);
        }
    }
}

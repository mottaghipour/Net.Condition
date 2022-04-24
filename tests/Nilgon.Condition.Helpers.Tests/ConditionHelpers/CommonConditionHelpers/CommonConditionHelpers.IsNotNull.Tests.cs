using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers
{
    public sealed class CommonConditionHelpers_IsNotNull_Tests
    {
        [Fact]
        public void IsNotNull_ReturnsFalse_WhenValueIsNull()
        {
            var value = null as string;

            var result = value.IsNotNull();

            Assert.False(result);
        }

        [Fact]
        public void IsNotNull_ReturnsTrue_WhenValueIsNotNull()
        {
            var value = "test";

            var result = value.IsNotNull();

            Assert.True(result);
        }
    }
}

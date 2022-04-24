using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers
{
    public sealed class CommonConditionHelpers_IsNotNull_Tests
    {
        [Fact]
        public void IsNotNull_ReturnsFalse_WhenValueIsNull()
        {
            object value = null;

            bool result = value.IsNotNull();

            Assert.False(result);
        }

        [Fact]
        public void IsNotNull_ReturnsTrue_WhenValueIsNotNull()
        {
            object value = "test";

            bool result = value.IsNotNull();

            Assert.True(result);
        }
    }
}

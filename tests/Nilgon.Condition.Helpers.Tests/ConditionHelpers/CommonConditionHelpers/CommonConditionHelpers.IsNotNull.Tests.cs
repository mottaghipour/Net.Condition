using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers
{
    public sealed class CommonConditionHelpers_IsNotNull_Tests
    {
        [Fact]
        public void NullValue_ReturnFalse()
        {
            var value = null as string;

            var result = value.IsNotNull();

            Assert.False(result);
        }

        [Fact]
        public void FullValue_ReturnTrue()
        {
            var value = "test";

            var result = value.IsNotNull();

            Assert.True(result);
        }
    }
}

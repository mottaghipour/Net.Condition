using Nilgon.Condition.Helpers.ConditionHelpers.CommonConditionHelpers;
using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers
{
    public sealed class CommonConditionHelpers_IsNull_Tests
    {
        [Fact]
        public void NullValue_ReturnTrue()
        {
            var value = null as string;

            var result = value.IsNull();

            Assert.True(result);
        }
        
        [Fact]
        public void NotNullValue_ReturnFalse()
        {
            var value = "test";

            var result = value.IsNull();

            Assert.False(result);
        }
    }
}

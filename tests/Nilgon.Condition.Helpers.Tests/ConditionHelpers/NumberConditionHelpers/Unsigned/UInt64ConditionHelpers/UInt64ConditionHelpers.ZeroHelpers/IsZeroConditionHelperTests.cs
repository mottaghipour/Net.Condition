using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UInt64ConditionHelpers.ZeroHelpers
{
    public sealed class IsZero_Condition_Helper_Tests
    {
        [Fact]
        public void IsZero_ReturnsTrue_WhenNumberIsZero()
        {
            ulong numberToTest = 0;
            
            bool result = numberToTest.IsZero();

            Assert.True(result);
        }

        [Fact]
        public void IsZero_ReturnsFalse_WhenNumberIsNotZero()
        {
            ulong numberToTest = 1;

            bool result = numberToTest.IsZero();

            Assert.False(result);
        }
    }
}

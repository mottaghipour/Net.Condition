using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UInt16ConditionHelpers.ZeroHelpers
{
    public sealed class IsNotZero_Condition_Helper_Tests
    {
        [Fact]
        public void IsNotZero_ReturnsTrue_WhenNumberIsNotZero()
        {
            ushort numberToTest = 1;

            bool result = numberToTest.IsNotZero();

            Assert.True(result);
        }

        [Fact]
        public void IsZero_ReturnsFalse_WhenNumberIsZero()
        {
            ushort numberToTest = 0;

            bool result = numberToTest.IsNotZero();

            Assert.False(result);
        }
    }
}

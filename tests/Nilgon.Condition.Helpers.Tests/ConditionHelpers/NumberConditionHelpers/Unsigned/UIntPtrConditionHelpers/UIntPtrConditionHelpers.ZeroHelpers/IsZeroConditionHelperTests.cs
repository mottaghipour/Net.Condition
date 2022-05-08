using System;
using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UIntPtrConditionHelpers.ZeroHelpers
{
    public sealed class IsZero_Condition_Helper_Tests
    {
        [Fact]
        public void IsZero_RetunsTrue_WhenNumberIsZero()
        {
            nuint numberToTest = UIntPtr.Zero;

            bool result = numberToTest.IsZero();

            Assert.True(result);
        }

        [Fact]
        public void IsZero_ReturnsFalse_WhenNumberIsNotZero()
        {
            nuint numberToTest = 1;

            bool result = numberToTest.IsZero();

            Assert.False(result);
        }
    }
}

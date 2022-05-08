using System;
using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.IntPtrConditionHelpers.ZeroHelpers;

public sealed class IsNotZero_Condition_Helper_Tests
{
    [Fact]
    public void IsNotZero_ReturnsTrue_WhenNumberIsNotZero()
    {
        nint numberToTest = 1;

        bool result = numberToTest.IsNotZero();

        Assert.True(result);
    }

    [Fact]
    public void IsNotZero_ReturnsFalse_WhenNumberIsZero()
    {
        nint numberToTest = IntPtr.Zero;

        bool result = numberToTest.IsNotZero();

        Assert.False(result);
    }
}

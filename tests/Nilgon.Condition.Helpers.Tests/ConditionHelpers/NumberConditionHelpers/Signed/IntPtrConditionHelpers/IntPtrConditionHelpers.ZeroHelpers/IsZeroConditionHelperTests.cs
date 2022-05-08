using System;
using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.IntPtrConditionHelpers.ZeroHelpers;

public sealed class IsZero_Condition_Helper_Tests
{
    [Fact]
    public void IsZero_ReturnsTrue_WhenNumberIsZero()
    {
        nint numberToTest = IntPtr.Zero;

        bool result = numberToTest.IsZero();

        Assert.True(result);
    }

    [Fact]
    public void IsZero_ReturnsFalse_WhenNumberIsNotZero()
    {
        nint numberToTest = 1;

        bool result = numberToTest.IsZero();

        Assert.False(result);
    }
}

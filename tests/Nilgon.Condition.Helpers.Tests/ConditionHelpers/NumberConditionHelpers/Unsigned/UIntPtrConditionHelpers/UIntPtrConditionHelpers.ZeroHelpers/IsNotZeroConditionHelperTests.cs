using System;
using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UIntPtrConditionHelpers.ZeroHelpers;

public sealed class IsNotZero_Condition_Helper_Tests
{
    [Fact]
    public void IsNotZero_ReturnsTrue_WhenNumberIsNotZero()
    {
        nuint numberToTest = 1;

        bool result = numberToTest.IsNotZero();

        Assert.True(result);
    }
    [Fact]
    public void IsNotZero_ReturnsFalse_WhenNumberIsZero()
    {
        nuint numberToTest = UIntPtr.Zero;

        bool result = numberToTest.IsNotZero();

        Assert.False(result);
    }
}

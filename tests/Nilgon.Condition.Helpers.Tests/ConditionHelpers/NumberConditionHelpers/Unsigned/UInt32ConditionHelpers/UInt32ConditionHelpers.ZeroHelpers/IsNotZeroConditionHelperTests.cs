using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UInt32ConditionHelpers.ZeroHelpers;

public sealed class IsNotZero_Condition_Helper_Tests
{
    [Fact]
    public void IsNotZero_ReturnsTrue_WhenNumberIsNotZero()
    {
        uint numberToTest = 1;

        bool result = numberToTest.IsNotZero();

        Assert.True(result);
    }

    [Fact]
    public void IsNotZero_ReturnsFalse_WhenNumberIsZero()
    {
        uint numberToTest = 0;

        bool result = numberToTest.IsNotZero();

        Assert.False(result);
    }
}

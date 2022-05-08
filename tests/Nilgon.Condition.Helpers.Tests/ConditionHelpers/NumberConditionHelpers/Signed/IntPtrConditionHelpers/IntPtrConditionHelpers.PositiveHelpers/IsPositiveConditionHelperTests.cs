using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.IntPtrConditionHelpers.PositiveHelpers;

public sealed class IsPositive_Condition_Helper_Tests
{
    [Fact]
    public void IsPositive_ReturnsTrue_WhenNumberIsPositive()
    {
        nint numberToTest = 1;

        bool result = numberToTest.IsPositive();

        Assert.True(result);
    }

    [Fact]
    public void IsPositive_ReturnsFalse_WhenNumberIsNegative()
    {
        nint numberToTest = -1;

        bool result = numberToTest.IsPositive();

        Assert.False(result);
    }
}

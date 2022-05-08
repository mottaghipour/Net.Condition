using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.IntPtrConditionHelpers.NegativeHelpers;

public sealed class IsNegative_Condition_Helper_Tests
{
    [Fact]
    public void IsNegative_ReturnsTrue_WhenNumberIsNegative()
    {
        nint numberToTest = -1;

        bool result = numberToTest.IsNegative();

        Assert.True(result);
    }

    [Fact]
    public void IsNegative_ReturnsFalse_WhenNumberIsPositive()
    {
        nint numberToTest = 1;

        bool result = numberToTest.IsNegative();

        Assert.False(result);
    }
}

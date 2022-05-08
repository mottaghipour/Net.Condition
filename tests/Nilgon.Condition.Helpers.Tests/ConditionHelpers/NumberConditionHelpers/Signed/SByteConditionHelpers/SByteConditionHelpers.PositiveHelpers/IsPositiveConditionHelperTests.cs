using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.SByteConditionHelpers.PositiveHelpers;

public sealed class IsPositive_Condition_Helper_Tests
{
    [Fact]
    public void IsPositive_ReturnsTrue_WhenNumberIsPositive()
    {
        sbyte numberToTest = 1;

        bool result = numberToTest.IsPositive();

        Assert.True(result);
    }

    [Fact]
    public void IsPositive_ReturnsFalse_WhenNumberIsNegative()
    {
        sbyte numberToTest = -1;

        bool result = numberToTest.IsPositive();

        Assert.False(result);
    }
}

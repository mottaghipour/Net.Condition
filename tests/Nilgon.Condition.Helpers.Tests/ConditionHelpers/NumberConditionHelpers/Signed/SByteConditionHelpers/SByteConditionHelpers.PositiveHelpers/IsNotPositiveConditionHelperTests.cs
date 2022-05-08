using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.SByteConditionHelpers.PositiveHelpers;

public sealed class IsNotPositive_Condition_Helper_Tests
{
    [Fact]
    public void IsNotPositive_ReturnsTrue_WhenNumberIsNegative()
    {
        sbyte numberToTest = -1;

        bool result = numberToTest.IsNotPositive();

        Assert.True(result);
    }

    [Fact]
    public void IsNotPositive_ReturnsFalse_WhenNumberIsPostive()
    {
        sbyte numberToTest = 1;

        bool result = numberToTest.IsNotPositive();

        Assert.False(result);
    }
}

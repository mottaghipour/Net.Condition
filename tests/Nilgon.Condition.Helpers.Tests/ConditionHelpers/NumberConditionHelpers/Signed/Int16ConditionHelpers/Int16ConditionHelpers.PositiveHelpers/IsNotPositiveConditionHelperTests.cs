using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int16ConditionHelpers.PositiveHelpers;

public sealed class IsNotPositive_Condition_Helper_Tests
{
    [Fact]
    public void IsNotPositive_ReturnsTrue_WhenNumberIsNegative()
    {
        short numberToTest = -1;

        bool result = numberToTest.IsNotPositive();

        Assert.True(result);
    }

    [Fact]
    public void IsNotPositive_ReturnsFalse_WhenNumberIsPostive()
    {
        short numberToTest = 1;

        bool result = numberToTest.IsNotPositive();

        Assert.False(result);
    }
}

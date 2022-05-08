using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.SByteConditionHelpers.NegativeHelpers;

public sealed class IsNotNegative_Condition_Helper_Tests
{
    [Fact]
    public void IsNotNegative_ReturnsTrue_WhenNumberIsPositive()
    {
        sbyte numberToTest = 1;

        bool result = numberToTest.IsNotNegative();

        Assert.True(result);
    }

    [Fact]
    public void IsNotNegative_ReturnsFalse_WhenNumberIsNegative()
    {
        sbyte numberToTest = -1;

        bool result = numberToTest.IsNotNegative();

        Assert.False(result);
    }
}

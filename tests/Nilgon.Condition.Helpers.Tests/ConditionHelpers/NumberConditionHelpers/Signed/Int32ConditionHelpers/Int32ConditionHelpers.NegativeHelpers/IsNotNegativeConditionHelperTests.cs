using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int32ConditionHelpers.NegativeHelpers;

public sealed class IsNotNegative_Condition_Helper_Tests
{
    [Fact]
    public void IsNotNegative_ReturnsTrue_WhenNumberIsPositive()
    {
        int numberToTest = 1;

        bool result = numberToTest.IsNotNegative();

        Assert.True(result);
    }

    [Fact]
    public void IsNotNegative_ReturnsFalse_WhenNumberIsNegative()
    {
        int numberToTest = -1;

        bool result = numberToTest.IsNotNegative();

        Assert.False(result);
    }
}

using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int32ConditionHelpers.PositiveHelpers;

public sealed class IsPositive_Condition_Helper_Tests
{
    [Fact]
    public void IsPositive_ReturnsTrue_WhenNumberIsPositive()
    {
        int numberToTest = 1;

        bool result = numberToTest.IsPositive();

        Assert.True(result);
    }

    [Fact]
    public void IsPositive_ReturnsFalse_WhenNumberIsNegative()
    {
        int numberToTest = -1;
        
        bool result = numberToTest.IsPositive();
        
        Assert.False(result);
    }
}

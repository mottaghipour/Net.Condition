using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int32ConditionHelpers.PositiveHelpers;

public sealed class IsNotPositive_Condition_Helper_Tests
{
    [Fact]
    public void IsNotPositive_ReturnsTrue_WhenNumberIsNegative()
    {
        int numberToTest = -1;

        bool result = numberToTest.IsNotPositive();

        Assert.True(result);
    }
    
    [Fact]
    public void IsNotPositive_ReturnsFalse_WhenNumberIsPostive()
    {
        int numberToTest = 1;

        bool result = numberToTest.IsNotPositive();

        Assert.False(result);
    }
}

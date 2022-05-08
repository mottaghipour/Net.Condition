using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int64ConditionHelpers.OddHelpers;

public sealed class IsNotOdd_Condition_Helper_Tests
{
    [Fact]
    public void IsNotOdd_ReturnsTrue_WhenNumberIsEven()
    {
        long numberToTest = 2;

        bool result = numberToTest.IsNotOdd();

        Assert.True(result);
    }

    [Fact]
    public void IsNotOdd_ReturnsFalse_WhenNumberIsOdd()
    {
        long numberToTest = 1;
        
        bool result = numberToTest.IsNotOdd();

        Assert.False(result);
    }
}

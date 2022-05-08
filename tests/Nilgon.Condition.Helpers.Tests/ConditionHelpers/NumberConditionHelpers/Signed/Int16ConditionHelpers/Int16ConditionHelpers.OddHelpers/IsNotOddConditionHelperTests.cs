using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int16ConditionHelpers.OddHelpers;

public sealed class IsNotOdd_Condition_Helper_Tests
{
    [Fact]
    public void IsNotOdd_ReturnsTrue_WhenNumberIsEven()
    {
        short numberToTest = 2;

        bool result = numberToTest.IsNotOdd();

        Assert.True(result);
    }

    [Fact]
    public void IsNotOdd_ReturnsFalse_WhenNumberIsOdd()
    {
        short numberToTest = 1;

        bool result = numberToTest.IsNotOdd();

        Assert.False(result);
    }
}

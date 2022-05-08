using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int32ConditionHelpers.OddHelpers;

public sealed class IsOdd_Condition_Helper_Tests
{
    [Fact]
    public void IsOdd_ReturnsTrue_WhenNumberIsOdd()
    {
        int numberToTest = 1;

        bool result = numberToTest.IsOdd();

        Assert.True(result);
    }

    [Fact]
    public void IsOdd_ReturnsFalse_WhenNumberIsEven()
    {
        int numberToTest = 2;

        bool result = numberToTest.IsOdd();

        Assert.False(result);
    }
}

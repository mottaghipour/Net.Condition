using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int32ConditionHelpers.OddHelpers;

public sealed class IsNotOdd_Condition_Helper_Tests
{
    [Fact]
    public void IsNotOdd_ReturnsTrue_WhenNumberIsEven()
    {
        int numberToTest = 2;

        bool result = numberToTest.IsNotOdd();

        Assert.True(result);
    }

    [Fact]
    public void IsNotOdd_ReturnsFalse_WhenNumberIsOdd()
    {
        int numberToTest = 1;

        bool result = numberToTest.IsNotOdd();

        Assert.False(result);
    }
}

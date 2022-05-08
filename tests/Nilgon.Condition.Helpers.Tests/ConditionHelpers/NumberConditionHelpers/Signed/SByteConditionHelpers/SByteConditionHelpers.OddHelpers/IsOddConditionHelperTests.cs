using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.SByteConditionHelpers.OddHelpers;

public sealed class IsOdd_Condition_Helper_Tests
{
    [Fact]
    public void IsOdd_ReturnsTrue_WhenNumberIsOdd()
    {
        sbyte numberToTest = 1;

        bool result = numberToTest.IsOdd();

        Assert.True(result);
    }

    [Fact]
    public void IsOdd_ReturnsFalse_WhenNumberIsEven()
    {
        sbyte numberToTest = 2;

        bool result = numberToTest.IsOdd();

        Assert.False(result);
    }
}
